using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CSI418Proj.Models;

namespace CSI418Proj.Controllers
{
    public class HREntriesController : Controller
    {
        private HRDB db = new HRDB();

        // GET: HREntries
        public ActionResult Index()
        {
            return View(db.DashboardViewModels.ToList());
        }

        // GET: HREntries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HREntry hREntry = db.DashboardViewModels.Find(id);
            if (hREntry == null)
            {
                return HttpNotFound();
            }
            return View(hREntry);
        }

        // GET: HREntries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HREntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FirstName,LastName,Department,JobTitle,HourlyPay,EmploymentStatus,Address,PhoneNumber,Email,ImagePath")] HREntry hREntry)
        {
            if (ModelState.IsValid)
            {
                db.DashboardViewModels.Add(hREntry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hREntry);
        }

        // GET: HREntries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HREntry hREntry = db.DashboardViewModels.Find(id);
            if (hREntry == null)
            {
                return HttpNotFound();
            }
            return View(hREntry);
        }

        // POST: HREntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FirstName,LastName,Department,JobTitle,HourlyPay,EmploymentStatus,Address,PhoneNumber,Email,ImagePath")] HREntry hREntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hREntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hREntry);
        }

        // GET: HREntries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HREntry hREntry = db.DashboardViewModels.Find(id);
            if (hREntry == null)
            {
                return HttpNotFound();
            }
            return View(hREntry);
        }

        // POST: HREntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HREntry hREntry = db.DashboardViewModels.Find(id);
            db.DashboardViewModels.Remove(hREntry);
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
