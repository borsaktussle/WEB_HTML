using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using final.Models;

namespace final.Controllers
{
    public class KOMENTARsController : Controller
    {
        private KepoITEntities db = new KepoITEntities();

        // GET: KOMENTARs
        public ActionResult Index()
        {
            var kOMENTAR = db.KOMENTAR.Include(k => k.ANSWER).Include(k => k.SHARING).Include(k => k.USER);
            return View(kOMENTAR.ToList());
        }

        // GET: KOMENTARs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KOMENTAR kOMENTAR = db.KOMENTAR.Find(id);
            if (kOMENTAR == null)
            {
                return HttpNotFound();
            }
            return View(kOMENTAR);
        }



        // GET: KOMENTARs/Create
        public ActionResult Create()
        {
            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT");
            ViewBag.ID_SHARING = new SelectList(db.SHARING, "ID_SHARING", "TITLE_SHARING");
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA");
            return View();
        }

        // POST: KOMENTARs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_KOMEN,ID_SHARING,ID_ANSWER,ID_USER,POST_KOMEN,TGL_KOMEN,CLAP_KOMENTAR,UPDATE_DATE,IS_ACTIVE")] KOMENTAR kOMENTAR)
        {
            if (ModelState.IsValid)
            {
                kOMENTAR.TGL_KOMEN = DateTime.Now;
                kOMENTAR.UPDATE_DATE = DateTime.Now;
                db.KOMENTAR.Add(kOMENTAR);
                db.SaveChanges();
                
                return RedirectToAction("../SHARINGs");
            }

            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT", kOMENTAR.ID_ANSWER);
            ViewBag.ID_SHARING = new SelectList(db.SHARING, "ID_SHARING", "TITLE_SHARING", kOMENTAR.ID_SHARING);
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA", kOMENTAR.ID_USER);
            return View(kOMENTAR);
        }

        // GET: KOMENTARs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KOMENTAR kOMENTAR = db.KOMENTAR.Find(id);
            if (kOMENTAR == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT", kOMENTAR.ID_ANSWER);
            ViewBag.ID_SHARING = new SelectList(db.SHARING, "ID_SHARING", "TITLE_SHARING", kOMENTAR.ID_SHARING);
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA", kOMENTAR.ID_USER);
            return View(kOMENTAR);
        }

        // POST: KOMENTARs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_KOMEN,ID_SHARING,ID_ANSWER,ID_USER,POST_KOMEN,TGL_KOMEN,CLAP_KOMENTAR,UPDATE_DATE,IS_ACTIVE")] KOMENTAR kOMENTAR)
        {
            if (ModelState.IsValid)
            {
                kOMENTAR.TGL_KOMEN = DateTime.Now;
                kOMENTAR.UPDATE_DATE = DateTime.Now;
                db.Entry(kOMENTAR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT", kOMENTAR.ID_ANSWER);
            ViewBag.ID_SHARING = new SelectList(db.SHARING, "ID_SHARING", "TITLE_SHARING", kOMENTAR.ID_SHARING);
            ViewBag.ID_USER = new SelectList(db.USER, "ID_USER", "NAMA", kOMENTAR.ID_USER);
            return View(kOMENTAR);
        }

        // GET: KOMENTARs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KOMENTAR kOMENTAR = db.KOMENTAR.Find(id);
            if (kOMENTAR == null)
            {
                return HttpNotFound();
            }
            return View(kOMENTAR);
        }

        // POST: KOMENTARs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KOMENTAR kOMENTAR = db.KOMENTAR.Find(id);
            db.KOMENTAR.Remove(kOMENTAR);
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
