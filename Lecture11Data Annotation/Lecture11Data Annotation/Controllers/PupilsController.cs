using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lecture11Data_Annotation.Models;

namespace Lecture11Data_Annotation.Controllers
{
    public class PupilsController : Controller
    {
        private PupilsContext db = new PupilsContext();

        // GET: Pupils
        public ActionResult Index()
        {
            return View(db.pupils.ToList());
        }

        // GET: Pupils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pupils pupils = db.pupils.Find(id);
            if (pupils == null)
            {
                return HttpNotFound();
            }
            return View(pupils);
        }

        // GET: Pupils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pupils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,Name,Marks,Email,Department,Mobile")] Pupils pupils)
        {
            if (ModelState.IsValid)
            {
                db.pupils.Add(pupils);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pupils);
        }

        // GET: Pupils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pupils pupils = db.pupils.Find(id);
            if (pupils == null)
            {
                return HttpNotFound();
            }
            return View(pupils);
        }

        // POST: Pupils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,Name,Marks,Email,Department,Mobile")] Pupils pupils)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pupils).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pupils);
        }

        // GET: Pupils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pupils pupils = db.pupils.Find(id);
            if (pupils == null)
            {
                return HttpNotFound();
            }
            return View(pupils);
        }

        // POST: Pupils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pupils pupils = db.pupils.Find(id);
            db.pupils.Remove(pupils);
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
