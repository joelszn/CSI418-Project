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
    public class MappedFieldsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MappedFields
        public ActionResult Index()
        {
            return View(db.MappedFields.ToList());
        }

        // GET: MappedFields/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MappedFields mappedFields = db.MappedFields.Find(id);
            if (mappedFields == null)
            {
                return HttpNotFound();
            }
            return View(mappedFields);
        }

        // GET: MappedFields/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MappedFields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FieldID,Field1,Field2,Field3,Field4,Field5,Field6,Field7,Field8,Field9,Field10,Field11")] MappedFields mappedFields)
        {
            if (ModelState.IsValid)
            {
                db.MappedFields.Add(mappedFields);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mappedFields);
        }

        // GET: MappedFields/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MappedFields mappedFields = db.MappedFields.Find(id);
            if (mappedFields == null)
            {
                return HttpNotFound();
            }
            return View(mappedFields);
        }

        // POST: MappedFields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FieldID,Field1,Field2,Field3,Field4,Field5,Field6,Field7,Field8,Field9,Field10,Field11")] MappedFields mappedFields)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mappedFields).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mappedFields);
        }

        // GET: MappedFields/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MappedFields mappedFields = db.MappedFields.Find(id);
            if (mappedFields == null)
            {
                return HttpNotFound();
            }
            return View(mappedFields);
        }

        // POST: MappedFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MappedFields mappedFields = db.MappedFields.Find(id);
            db.MappedFields.Remove(mappedFields);
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
