using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using final.Models;
using System.IO;

namespace final.Controllers
{
    public class SHARINGsController : Controller
    {
        private KepoITEntities db = new KepoITEntities();

        //GET: SHARINGs
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            var sHARING = db.SHARING.Include(s => s.TAGS).Include(s => s.USER);
            return View(sHARING.ToList());

        }


        // GET: SHARINGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHARING sHARING = db.SHARING.Find(id);
            if (sHARING == null)
            {
                return HttpNotFound();
            }
            return View(sHARING);
        }

        // GET: SHARINGs/Create
        public ActionResult Create()
        {
            ViewBag.ID_TAGS = new SelectList(db.TAGS, "ID_TAGS", "TAGSNAME");
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA");
            return View();
        }

        // POST: SHARINGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HttpPostedFileBase file,[Bind(Include = "ID_SHARING,ID_USER,ID_TAGS,TITLE_SHARING,POSTTING,TGGL_SHARE,UPLOAD_FILE,CLAP_SHARING,UPDATE_DATE")] SHARING sHARING)
        {
            if (ModelState.IsValid)
            {
                sHARING.TGGL_SHARE = DateTime.Now;
                sHARING.UPDATE_DATE = DateTime.Now;
                if (file != null && file.ContentLength > 0)
                {
                    // extract only the filename
                    var fileName = Path.GetFileName(file.FileName);
                    // store the file inside ~/App_Data/uploads folder
                    var path = Path.Combine(Server.MapPath("~/Content/Upload_file"), fileName);
                    file.SaveAs(path);
                    sHARING.UPLOAD_FILE = fileName;
                }
                db.SHARING.Add(sHARING);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_TAGS = new SelectList(db.TAGS, "ID_TAGS", "TAGSNAME", sHARING.ID_TAGS);
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA", sHARING.ID_USER);
            return View(sHARING);
            // Verify that the user selected a file
        }

    // GET: SHARINGs/Edit/5
    public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHARING sHARING = db.SHARING.Find(id);
            if (sHARING == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_TAGS = new SelectList(db.TAGS, "ID_TAGS", "TAGSNAME", sHARING.ID_TAGS);
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA", sHARING.ID_USER);
            return View(sHARING);
        }

        // POST: SHARINGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SHARING,ID_USER,ID_TAGS,TITLE_SHARING,POSTTING,TGGL_SHARE,UPLOAD_FILE,CLAP_SHARING,UPDATE_DATE")] SHARING sHARING)
        {
            if (ModelState.IsValid)
            {
                sHARING.TGGL_SHARE = DateTime.Now;
                sHARING.UPDATE_DATE = DateTime.Now;
                db.Entry(sHARING).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_TAGS = new SelectList(db.TAGS, "ID_TAGS", "TAGSNAME", sHARING.ID_TAGS);
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA", sHARING.ID_USER);
            return View(sHARING);
        }

        // GET: SHARINGs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHARING sHARING = db.SHARING.Find(id);
            if (sHARING == null)
            {
                return HttpNotFound();
            }
            return View(sHARING);
        }

        // POST: SHARINGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SHARING sHARING = db.SHARING.Find(id);
            db.SHARING.Remove(sHARING);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
