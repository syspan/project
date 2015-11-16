using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Agendo.Dal;

namespace Agendo.Controllers
{
    public class ServiceController : ApiController
    {
        ServicePersistor _repository;

        public ServiceController()
        {
            _repository = new ServicePersistor();
        }

        [HttpGet]
        [Queryable]
        public HttpResponseMessage ServicesSummary()
        {
            int totalRecords;
            var servSummary = _repository.GetServices(out totalRecords);
            HttpContext.Current.Response.Headers.Add("X-InlineCount", totalRecords.ToString());
            return Request.CreateResponse(HttpStatusCode.OK, servSummary);
        }
    }
}