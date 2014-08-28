using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Syspan.Core.Models;
using Syspan.Core.Dal;

namespace Syspan.Admin.Controllers
{
    public class GirosController : Controller
    {
        private SyspanContext db = new SyspanContext();

        // GET: /Giros/
        public ActionResult Index()
        {
            return View(db.Giros.ToList());
        }

        // GET: /Giros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giro giro = db.Giros.Find(id);
            if (giro == null)
            {
                return HttpNotFound();
            }
            return View(giro);
        }

        // GET: /Giros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Giros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Nombre")] Giro giro)
        {
            if (ModelState.IsValid)
            {
                db.Giros.Add(giro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giro);
        }

        // GET: /Giros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giro giro = db.Giros.Find(id);
            if (giro == null)
            {
                return HttpNotFound();
            }
            return View(giro);
        }

        // POST: /Giros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Nombre")] Giro giro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giro);
        }

        // GET: /Giros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giro giro = db.Giros.Find(id);
            if (giro == null)
            {
                return HttpNotFound();
            }
            return View(giro);
        }

        // POST: /Giros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Giro giro = db.Giros.Find(id);
            db.Giros.Remove(giro);
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
