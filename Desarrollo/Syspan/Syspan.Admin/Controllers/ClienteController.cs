using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Syspan.Admin.Models.Views;
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
            var clients = Mapper.Map<List<Cliente>, List<ClienteModel>>(db.Clientes.ToList()); //.Include(p => p.Giro).ToList()
            
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
        public ActionResult Create([Bind(Include = "Rut,Memotecnico,Nombre,Email,NombreFantasia,CodSucursal,Memotecnico,SaldoMax,Observacion,IdGiro,IdReparto,IdFormaPago,IdEstado")] ClienteModel clientemodel)
        {
            Mapper.CreateMap<ClienteModel, Cliente>();
            var client = Mapper.Map<ClienteModel, Cliente>(clientemodel);

            if (ModelState.IsValid)
            {
                db.Entidades.Add(
                    new Entidad{
                        Email = clientemodel.Email,
                        Rut = clientemodel.Rut,
                        Nombre = clientemodel.Nombre
         
                    }
                    );
                db.SaveChanges();
                db.Clientes.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.IdGiro = new SelectList(db.Giros, "Id", "Nombre");
                ViewBag.IdReparto = new SelectList(db.RepartoZonas, "Id", "Nombre");
                ViewBag.IdFormaPago = new SelectList(db.FormaDePagos, "Id", "Nombre");
                ViewBag.IdEstado = new SelectList(db.ClienteEstados, "Id", "Nombre");

            }

            return View(clientemodel);
        }

        // GET: /Cliente/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Mapper.CreateMap<Cliente, ClienteModel>();
            var client = Mapper.Map<Cliente, ClienteModel>(db.Clientes.Find(id));
            
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: /Cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Rut,NombreFantasia,CodSucursal,Memotecnico,SaldoMax,Observacion")] ClienteModel clientemodel)
        {
            Mapper.CreateMap<ClienteModel, Cliente>();
            var client = Mapper.Map<ClienteModel, Cliente>(clientemodel);

            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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

            if (client == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        //// POST: /Cliente/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    ClienteModel clientemodel = db.ClienteModels.Find(id);
        //    db.ClienteModels.Remove(clientemodel);
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
