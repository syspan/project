using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Agendo.ServiceLayer.Model.Service;
using Agendo.ServiceLayer.Dal;

namespace Agendo.UI.Controllers
{
    public class ServicioController : Controller
    {
        private AgendoContext db = new AgendoContext();

        // GET: /Servicio/
        public ActionResult Index()
        {
            var services = db.Services.Include(s => s.Category);
            return View(services.ToList());
        }

        // GET: /Servicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfo serviceinfo = db.Services.Find(id);
            if (serviceinfo == null)
            {
                return HttpNotFound();
            }
            return View(serviceinfo);
        }

        // GET: /Servicio/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.CategoryInfoes, "Id", "Name");
            return View();
        }

        // POST: /Servicio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,AvgTime,Price,CategoryId,Status")] ServiceInfo serviceinfo)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(serviceinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.CategoryInfoes, "Id", "Name", serviceinfo.CategoryId);
            return View(serviceinfo);
        }

        // GET: /Servicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfo serviceinfo = db.Services.Find(id);
            if (serviceinfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.CategoryInfoes, "Id", "Name", serviceinfo.CategoryId);
            return View(serviceinfo);
        }

        // POST: /Servicio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,AvgTime,Price,CategoryId,Status")] ServiceInfo serviceinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.CategoryInfoes, "Id", "Name", serviceinfo.CategoryId);
            return View(serviceinfo);
        }

        // GET: /Servicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfo serviceinfo = db.Services.Find(id);
            if (serviceinfo == null)
            {
                return HttpNotFound();
            }
            return View(serviceinfo);
        }

        // POST: /Servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceInfo serviceinfo = db.Services.Find(id);
            db.Services.Remove(serviceinfo);
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
