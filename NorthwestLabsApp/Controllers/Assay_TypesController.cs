using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NorthwestLabsApp.DAL;
using NorthwestLabsApp.Models;

namespace NorthwestLabsApp.Controllers
{
    public class Assay_TypesController : Controller
    {
        private NorthwestContext db = new NorthwestContext();

        // GET: Assay_Types
        public ActionResult Catalog()
        {
            IEnumerable<Catalog_Items> lstCatalog = db.Database.SqlQuery<Catalog_Items>(
                "SELECT T.AssayType, T.AssayDesc, T.AssayProtocol, T.Materials, LR.Title " +
                "FROM Assay_Types T " +
                "LEFT JOIN Assay_References R ON T.AssayType = R.AssayType " +
                "LEFT JOIN Literature_References LR ON R.ReferenceID = LR.ReferenceID").ToList();
            ViewBag.Catalog = lstCatalog;
            return View();
        }

        // GET: Assay_Types/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Types assay_Types = db.assay_types.Find(id);
            if (assay_Types == null)
            {
                return HttpNotFound();
            }
            return View(assay_Types);
        }

        // GET: Assay_Types/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assay_Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssayType,AssayDesc,AssayProtocol,DaysToComplete,Materials")] Assay_Types assay_Types)
        {
            if (ModelState.IsValid)
            {
                db.assay_types.Add(assay_Types);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assay_Types);
        }

        // GET: Assay_Types/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Types assay_Types = db.assay_types.Find(id);
            if (assay_Types == null)
            {
                return HttpNotFound();
            }
            return View(assay_Types);
        }

        // POST: Assay_Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssayType,AssayDesc,AssayProtocol,DaysToComplete,Materials")] Assay_Types assay_Types)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assay_Types).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assay_Types);
        }

        // GET: Assay_Types/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Types assay_Types = db.assay_types.Find(id);
            if (assay_Types == null)
            {
                return HttpNotFound();
            }
            return View(assay_Types);
        }

        // POST: Assay_Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Assay_Types assay_Types = db.assay_types.Find(id);
            db.assay_types.Remove(assay_Types);
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
