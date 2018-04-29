using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CSI418Proj.Models
{
    public class FieldMappingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FieldMappings
        public ActionResult Index()
        {
            return View(db.FieldMappings.ToList());
        }

        // GET: FieldMappings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FieldMapping fieldMapping = db.FieldMappings.Find(id);
            if (fieldMapping == null)
            {
                return HttpNotFound();
            }
            return View(fieldMapping);
        }

        // GET: FieldMappings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FieldMappings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FieldNum,FieldName")] FieldMapping fieldMapping)
        {
            if (ModelState.IsValid)
            {
                db.FieldMappings.Add(fieldMapping);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fieldMapping);
        }

        // GET: FieldMappings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FieldMapping fieldMapping = db.FieldMappings.Find(id);
            if (fieldMapping == null)
            {
                return HttpNotFound();
            }
            return View(fieldMapping);
        }

        // POST: FieldMappings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FieldNum,FieldName")] FieldMapping fieldMapping)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fieldMapping).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("../Home/Index");
            }
            return View("..Home/Index");
        }

        // GET: FieldMappings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FieldMapping fieldMapping = db.FieldMappings.Find(id);
            if (fieldMapping == null)
            {
                return HttpNotFound();
            }
            return View(fieldMapping);
        }

        // POST: FieldMappings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FieldMapping fieldMapping = db.FieldMappings.Find(id);
            db.FieldMappings.Remove(fieldMapping);
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
