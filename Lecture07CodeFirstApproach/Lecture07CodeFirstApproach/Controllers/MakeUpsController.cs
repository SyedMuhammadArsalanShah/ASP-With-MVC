using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lecture07CodeFirstApproach.Models;

namespace Lecture07CodeFirstApproach.Controllers
{
    public class MakeUpsController : Controller
    {
        private MakeupContext db = new MakeupContext();

        // GET: MakeUps
        public ActionResult Index()
        {
            return View(db.misbah.ToList());
        }

        // GET: MakeUps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MakeUp makeUp = db.misbah.Find(id);
            if (makeUp == null)
            {
                return HttpNotFound();
            }
            return View(makeUp);
        }

        // GET: MakeUps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MakeUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,product,price")] MakeUp makeUp)
        {
            if (ModelState.IsValid)
            {
                db.misbah.Add(makeUp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(makeUp);
        }

        // GET: MakeUps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MakeUp makeUp = db.misbah.Find(id);
            if (makeUp == null)
            {
                return HttpNotFound();
            }
            return View(makeUp);
        }

        // POST: MakeUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,product,price")] MakeUp makeUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(makeUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(makeUp);
        }

        // GET: MakeUps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MakeUp makeUp = db.misbah.Find(id);
            if (makeUp == null)
            {
                return HttpNotFound();
            }
            return View(makeUp);
        }

        // POST: MakeUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MakeUp makeUp = db.misbah.Find(id);
            db.misbah.Remove(makeUp);
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
