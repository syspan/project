using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Agendo.ServiceLayer.Dal;

namespace Agendo.UI.Controllers
{
   public class ServiceController : ApiController
    {
        private AgendoContext db = new AgendoContext();


        // GET api/Servicio
       [Route("api/services")]
       //[HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, db.Services.ToList());
                return response;
            }
            catch (Exception ex)
            {
                
                throw;
            }
           
        }


        //// GET api/Servicio/5
        //[ResponseType(typeof(ServiceInfo))]
        //public IHttpActionResult GetServiceInfo(int id)
        //{
        //    ServiceInfo serviceinfo = db.Services.Find(id);
        //    if (serviceinfo == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(serviceinfo);
        //}

        //// PUT api/Servicio/5
        //public IHttpActionResult PutServiceInfo(int id, ServiceInfo serviceinfo)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != serviceinfo.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(serviceinfo).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ServiceInfoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST api/Servicio
        //[ResponseType(typeof(ServiceInfo))]
        //public IHttpActionResult PostServiceInfo(ServiceInfo serviceinfo)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Services.Add(serviceinfo);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = serviceinfo.Id }, serviceinfo);
        //}

        //// DELETE api/Servicio/5
        //[ResponseType(typeof(ServiceInfo))]
        //public IHttpActionResult DeleteServiceInfo(int id)
        //{
        //    ServiceInfo serviceinfo = db.Services.Find(id);
        //    if (serviceinfo == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Services.Remove(serviceinfo);
        //    db.SaveChanges();

        //    return Ok(serviceinfo);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServiceInfoExists(int id)
        {
            return db.Services.Count(e => e.Id == id) > 0;
        }
    }
}