using GoogleAuthentication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAuthDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var clientId = "71950734407-656m18mrqulka97ep4pqqlm37gabomr7.apps.googleusercontent.com";
            var url = "https://localhost:44301/Login/GoogleLoginCallBack";
            var response = GoogleAuth.GetAuthUrl(clientId, url);
            ViewData["response"] = response;
            return View();
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