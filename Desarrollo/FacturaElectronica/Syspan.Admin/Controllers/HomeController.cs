using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syspan.Admin.Models.Views;

namespace Syspan.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        [OutputCache(NoStore = true, Duration = 0)]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid && ValidateLogin(model.UserName, model.Password))
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        ///BORRAR - ES SOLO TEMPORAL
        private bool ValidateLogin(string user, string pass)
        {
            if(user == "syspan" && pass == "syspan123")
            return true;

            return false;
           

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}