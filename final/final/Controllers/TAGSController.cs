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
    public class TAGSController : Controller
    {
        private KepoITEntities db = new KepoITEntities();

        // GET: TAGS
        public ActionResult Index()
        {
            return View(db.TAGS.ToList());
        }

        // GET: TAGS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAGS tAGS = db.TAGS.Find(id);
            if (tAGS == null)
            {
                return HttpNotFound();
            }
            return View(tAGS);
        }

        // GET: TAGS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TAGS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TAGS,TAGSNAME")] TAGS tAGS)
        {
            if (ModelState.IsValid)
            {
                db.TAGS.Add(tAGS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tAGS);
        }

        // GET: TAGS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAGS tAGS = db.TAGS.Find(id);
            if (tAGS == null)
            {
                return HttpNotFound();
            }
            return View(tAGS);
        }

        // POST: TAGS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TAGS,TAGSNAME")] TAGS tAGS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAGS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tAGS);
        }

        // GET: TAGS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAGS tAGS = db.TAGS.Find(id);
            if (tAGS == null)
            {
                return HttpNotFound();
            }
            return View(tAGS);
        }

        // POST: TAGS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TAGS tAGS = db.TAGS.Find(id);
            db.TAGS.Remove(tAGS);
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
