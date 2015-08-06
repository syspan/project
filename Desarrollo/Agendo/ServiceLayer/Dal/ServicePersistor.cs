using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Agendo.ServiceLayer.Model.Service;
namespace Agendo.ServiceLayer.Dal
{
    public class ServicePersistor
    {
        private AgendoContext db = null;

        public ServicePersistor()
        {
            db = new AgendoContext();
        }

        /// <summary>
        /// Read a service based on a specific identifier.
        /// </summary>
        /// <param name="id">The indentifier</param>
        /// <returns></returns>
        internal ServiceInfo Read(int id)
        {
            return db.Services.FirstOrDefault(p => p.Id == id);
        }
        /// <summary>
        /// Get the service list based on the filter criteria.
        /// </summary>
        /// <param name="criteria">The filter criteria</param>
        /// <returns>Client List</returns>
        internal IList<ServiceInfo> GetList(Criteria criteria)
        {
            return (from c in db.Services
                    where c.Name == criteria.Name
                    || c.Category.Id == criteria.Category.Id
                    || c.Status == criteria.Status
                    select c
                    ).ToList();
        }
        /// <summary>
        /// Save a specific service
        /// </summary>
        /// <param name="info">The service info</param>
        internal void Save(ServiceInfo info)
        {
            db.Services.Add(info);
            db.SaveChanges();
        }
        /// <summary>
        /// Modify a specific service
        /// </summary>
        /// <param name="info">The service info.</param>
        internal void Modify(ServiceInfo info)
        {
            db.Entry(info).State = EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// Delete a specific service
        /// </summary>
        /// <param name="id">The service info</param>
        internal void Delete(int id)
        {
            var info = db.Services.FirstOrDefault(p => p.Id == id);
            if (info == null)
                throw new InvalidOperationException("El cliente no existe");

            info.Status = Agendo.ServiceLayer.Model.GeneralStatus.Deleted;
            db.Entry(info).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
