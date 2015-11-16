using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Agendo.ServiceLayer.Model.Clientes;
using Agendo.ServiceLayer.Model;
namespace Agendo.ServiceLayer.Dal
{
    public class ClientesPersistor
    {
        private AgendoContext db = null;

        public ClientesPersistor()
        {
            db = new AgendoContext();
        }

        /// <summary>
        /// Read a client based on a specific identifier.
        /// </summary>
        /// <param name="rut">The chiliean indentifier</param>
        /// <returns></returns>
        internal ClienteInfo Read(string rut)
        {
            return db.Clientes.FirstOrDefault(p => p.Rut == rut);
        }
        /// <summary>
        /// Get the client list based on the filter criteria.
        /// </summary>
        /// <param name="criteria">The filter criteria</param>
        /// <returns>Client List</returns>
        internal IList<ClienteInfo> GetList(Criteria criteria)
        {
            return (from c in db.Clientes
                    where c.Rut == criteria.Rut
                    || c.RazonSocial == criteria.RazonSocial
                    || c.NombreFantasia == criteria.NombreFantasia
                    || c.Giro == criteria.Giro
                    || c.Estado == criteria.Estado
                    select c
                    ).ToList();
        }
      
        internal void Save(ClienteInfo info)
        {
            db.Clientes.Add(info);
            db.SaveChanges();
        }

        internal void Modify(ClienteInfo info)
        {
            db.Entry(info).State = EntityState.Modified;
            db.SaveChanges();
        }

        internal void Delete(string rut)
        {
            var info = db.Clientes.FirstOrDefault(p => p.Rut == rut);
            if (info == null)
                throw new InvalidOperationException("El cliente no existe");

            info.Estado = GeneralStatus.Deleted;
            db.Entry(info).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
