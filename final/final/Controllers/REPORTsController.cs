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
    public class REPORTsController : Controller
    {
        private KepoITEntities db = new KepoITEntities();

        // GET: REPORTs
        public ActionResult Index()
        {
            var rEPORT = db.REPORT.Include(r => r.ANSWER).Include(r => r.KATEGORY_REPORT).Include(r => r.KOMENTAR);
            return View(rEPORT.ToList());
        }

        // GET: REPORTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPORT rEPORT = db.REPORT.Find(id);
            if (rEPORT == null)
            {
                return HttpNotFound();
            }
            return View(rEPORT);
        }

        // GET: REPORTs/Create
        public ActionResult Create()
        {
            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT");
            ViewBag.ID_KATEGORY = new SelectList(db.KATEGORY_REPORT, "ID_KATEGORY", "NAMA_KATEGORY");
            ViewBag.ID_KOMEN = new SelectList(db.KOMENTAR, "ID_KOMEN", "POST_KOMEN");
            return View();
        }

        // POST: REPORTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_REPORT,ID_KOMEN,ID_ANSWER,ID_KATEGORY")] REPORT rEPORT)
        {
            if (ModelState.IsValid)
            {
                db.REPORT.Add(rEPORT);
                db.SaveChanges();
                return RedirectToAction("../SHARINGs");
            }

            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT", rEPORT.ID_ANSWER);
            ViewBag.ID_KATEGORY = new SelectList(db.KATEGORY_REPORT, "ID_KATEGORY", "NAMA_KATEGORY", rEPORT.ID_KATEGORY);
            ViewBag.ID_KOMEN = new SelectList(db.KOMENTAR, "ID_KOMEN", "POST_KOMEN", rEPORT.ID_KOMEN);
            return View(rEPORT);
        }

        // GET: REPORTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPORT rEPORT = db.REPORT.Find(id);
            if (rEPORT == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT", rEPORT.ID_ANSWER);
            ViewBag.ID_KATEGORY = new SelectList(db.KATEGORY_REPORT, "ID_KATEGORY", "NAMA_KATEGORY", rEPORT.ID_KATEGORY);
            ViewBag.ID_KOMEN = new SelectList(db.KOMENTAR, "ID_KOMEN", "POST_KOMEN", rEPORT.ID_KOMEN);
            return View(rEPORT);
        }

        // POST: REPORTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_REPORT,ID_KOMEN,ID_ANSWER,ID_KATEGORY")] REPORT rEPORT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rEPORT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ANSWER = new SelectList(db.ANSWER, "ID_ANSWER", "POST_KOMENT", rEPORT.ID_ANSWER);
            ViewBag.ID_KATEGORY = new SelectList(db.KATEGORY_REPORT, "ID_KATEGORY", "NAMA_KATEGORY", rEPORT.ID_KATEGORY);
            ViewBag.ID_KOMEN = new SelectList(db.KOMENTAR, "ID_KOMEN", "POST_KOMEN", rEPORT.ID_KOMEN);
            return View(rEPORT);
        }

        // GET: REPORTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPORT rEPORT = db.REPORT.Find(id);
            if (rEPORT == null)
            {
                return HttpNotFound();
            }
            return View(rEPORT);
        }

        // POST: REPORTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            REPORT rEPORT = db.REPORT.Find(id);
            db.REPORT.Remove(rEPORT);
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
