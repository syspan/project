using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Syspan.Admin.Models.Views;
using Syspan.Admin.Properties;
using Syspan.Core.Dal;
using Syspan.Core.Models.Generic;
using AutoMapper;

namespace Syspan.Admin.Controllers
{
    public class DireccionController : Controller
    {
        private SyspanContext db = new SyspanContext();

        // GET: /Direccion/
        public ActionResult Index(string id)
        {
            Mapper.CreateMap<Direccion, DireccionModel>();
            var direcciones = Mapper.Map<List<Direccion>, List<DireccionModel>>(db.Direcciones.Where(p => p.Rut == id).ToList());

            var address = GetPersistAddress();
            direcciones.Add(address);

            return PartialView("Index", direcciones);

        }

       

        // GET: /Direccion/Create
        public ActionResult Create()
        {
            ViewBag.IdComuna = new SelectList(db.Comunas, "Id", "Nombre");
            ViewBag.IdProvincia = new SelectList(db.Provincias, "Id", "Nombre");
            ViewBag.IdRegion = new SelectList(db.Regiones, "Id", "Nombre");

            return PartialView("Create");
        }

        // POST: /Direccion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create([Bind(Include = "Id,Descripcion,Numero,Tipo,IdComuna,IdProvincia,IdRegion")] DireccionModel direccionmodel)
        {
            //if (ModelState.IsValid)
            //{
            //    return Json(GetJsonValue(true, "Success"));
            //}

           PersistAddress(direccionmodel);
           string url = Url.Action("Index", "Direccion");
           return Json(new { success = true, url = url });

            // return Json(GetJsonValue(true, "Error"));
        }

        /// <summary>
        /// 
        /// </summary>
        private void PersistAddress(DireccionModel direccionmodel)
        {
            Session["direccionmodel"] = direccionmodel;
        }

        /// <summary>
        /// 
        /// </summary>
        private DireccionModel GetPersistAddress()
        {
            return (DireccionModel) (Session["direccionmodel"] ?? new DireccionModel());
        }

        private static Dictionary<string, string> GetJsonValue(bool status, string message)
        {
            var jsonResult = new Dictionary<string, string> { { "Success", status.ToString() }, { "Message", message } };
            return jsonResult;
        }

        //// GET: /Direccion/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DireccionModel direccionmodel = db.DireccionModels.Find(id);
        //    if (direccionmodel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(direccionmodel);
        //}

        //// POST: /Direccion/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="Id,Descripcion,Numero,Tipo,IdComuna,IdProvincia,IdRegion")] DireccionModel direccionmodel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(direccionmodel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(direccionmodel);
        //}

        //// GET: /Direccion/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DireccionModel direccionmodel = db.DireccionModels.Find(id);
        //    if (direccionmodel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(direccionmodel);
        //}

        //// POST: /Direccion/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    DireccionModel direccionmodel = db.DireccionModels.Find(id);
        //    db.DireccionModels.Remove(direccionmodel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
