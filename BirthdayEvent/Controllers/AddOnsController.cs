using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BirthdayEvent.Models;

namespace BirthdayEvent.Controllers
{
    public class AddOnsController : Controller
    {
        private DBContextClass db = new DBContextClass();

        // GET: AddOns
        public ActionResult Index()
        {
            return View(db.AddOn.ToList());
        }

        // GET: AddOns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddOn addOn = db.AddOn.Find(id);
            if (addOn == null)
            {
                return HttpNotFound();
            }
            return View(addOn);
        }

        // GET: AddOns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddOns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "addOnId,addOnName,addOnDescription,addOnPrice,addOnImageURL")] AddOn addOn)
        {
            if (ModelState.IsValid)
            {
                db.AddOn.Add(addOn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addOn);
        }

        // GET: AddOns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddOn addOn = db.AddOn.Find(id);
            if (addOn == null)
            {
                return HttpNotFound();
            }
            return View(addOn);
        }

        // POST: AddOns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "addOnId,addOnName,addOnDescription,addOnPrice,addOnImageURL")] AddOn addOn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addOn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addOn);
        }

        // GET: AddOns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddOn addOn = db.AddOn.Find(id);
            if (addOn == null)
            {
                return HttpNotFound();
            }
            return View(addOn);
        }

        // POST: AddOns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddOn addOn = db.AddOn.Find(id);
            db.AddOn.Remove(addOn);
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
