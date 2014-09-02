using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Syspan.Admin.Models.Views;
using Syspan.Admin.Properties;
using Syspan.Core.Dal;
using Syspan.Core.Models;
using Syspan.Core.Models.Generic;

namespace Syspan.Admin.Controllers
{
    public class ClienteController : Controller
    {
        private SyspanContext db = new SyspanContext();

        // GET: /Cliente/
        public ActionResult Index()
        {
            Mapper.CreateMap<Cliente, ClienteModel>();
            var clients = Mapper.Map<List<Cliente>, List<ClienteModel>>(db.Clientes.Include(c => c.Giro).Include(c => c.FormaDePago).Include(c=> c.RepartoZona).ToList());
            
            return View(clients);
        }

        // GET: /Cliente/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Mapper.CreateMap<Cliente, ClienteModel>();

            ClienteModel clientemodel = Mapper.Map<Cliente, ClienteModel>(db.Clientes.Find(id));
            if (clientemodel == null)
            {
                return HttpNotFound();
            }
            return View(clientemodel);
        }

        // GET: /Cliente/Create
        public ActionResult Create()
        {
            ViewBag.IdGiro = new SelectList(db.Giros, "Id", "Nombre");
            ViewBag.IdReparto = new SelectList(db.RepartoZonas, "Id", "Nombre");
            ViewBag.IdFormaPago = new SelectList(db.FormaDePagos, "Id", "Nombre");
            ViewBag.IdEstado = new SelectList(db.ClienteEstados, "Id", "Nombre");

            return View();
        }

        // POST: /Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(
                Include =
                    "Rut,Memotecnico,Nombre,Email,NombreFantasia,CodSucursal,Memotecnico,SaldoMax,Observacion,IdGiro,IdReparto,IdFormaPago,IdEstado"
                )] ClienteModel clientemodel)
        {
            Mapper.CreateMap<ClienteModel, Cliente>();
            clientemodel.Rut = clientemodel.Rut.Replace("-", "").Replace(".", "");
            var client = Mapper.Map<ClienteModel, Cliente>(clientemodel);

            if (ModelState.IsValid)
            { 
                db.Clientes.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdGiro = new SelectList(db.Giros, "Id", "Nombre");
            ViewBag.IdReparto = new SelectList(db.RepartoZonas, "Id", "Nombre");
            ViewBag.IdFormaPago = new SelectList(db.FormaDePagos, "Id", "Nombre");
            ViewBag.IdEstado = new SelectList(db.ClienteEstados, "Id", "Nombre");

            return View(clientemodel);
        }
    

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Mapper.CreateMap<Cliente, ClienteModel>();
            var client = Mapper.Map<Cliente, ClienteModel>(db.Clientes.Find(id));

            ViewBag.IdGiro = new SelectList(db.Giros, "Id", "Nombre", client.IdGiro);
            ViewBag.IdReparto = new SelectList(db.RepartoZonas, "Id", "Nombre", client.IdReparto);
            ViewBag.IdFormaPago = new SelectList(db.FormaDePagos, "Id", "Nombre", client.IdFormaPago);
            ViewBag.IdEstado = new SelectList(db.ClienteEstados, "Id", "Nombre", client.IdEstado);
            
        
            return View(client);
        }

        // POST: /Cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Rut,Memotecnico,Nombre,Email,NombreFantasia,CodSucursal,Memotecnico,SaldoMax,Observacion,IdGiro,IdReparto,IdFormaPago,IdEstado")] ClienteModel clientemodel)
        {
            Mapper.CreateMap<ClienteModel, Cliente>();
            var client = Mapper.Map<ClienteModel, Cliente>(clientemodel);

            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdGiro = new SelectList(db.Giros, "Id", "Nombre");
            ViewBag.IdReparto = new SelectList(db.RepartoZonas, "Id", "Nombre");
            ViewBag.IdFormaPago = new SelectList(db.FormaDePagos, "Id", "Nombre");
            ViewBag.IdEstado = new SelectList(db.ClienteEstados, "Id", "Nombre");


            return View(clientemodel);
        }

        // GET: /Cliente/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapper.CreateMap<Cliente, ClienteModel>();
            var client = db.Clientes.Find(id);
            db.Clientes.Remove(client);
            db.SaveChanges();

            if (client == null)
            {
                return HttpNotFound();
            }
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


        #region remote validations
        public JsonResult ClientExists(string rut)
        {
            var user = db.Clientes.FirstOrDefault(p => p.Rut == rut.Replace(".","").Replace("-",""));
            return user == null ?
                Json(true, JsonRequestBehavior.AllowGet) :
                Json(string.Format("{0} {1}", rut, Resources.ClientRut_Duplicate_Error),
                    JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}
