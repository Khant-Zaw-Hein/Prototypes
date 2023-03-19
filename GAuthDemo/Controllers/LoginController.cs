using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GAuthDemo.Models;
using GoogleAuthentication.Services;
using Newtonsoft.Json;

namespace GAuthDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {


            return View();
        }

        public async Task<ActionResult> GoogleLoginCallBack(string code)
        {
            var clientId = "71950734407-656m18mrqulka97ep4pqqlm37gabomr7.apps.googleusercontent.com";
            var url = "https://localhost:44301/Login/GoogleLoginCallBack";
            var clientSecret = "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";
            var token = await GoogleAuth.GetAuthAccessToken(code, clientId, clientSecret, url);
            var userProfile = await GoogleAuth.GetProfileResponseAsync(token.AccessToken.ToString());
            var googleUser = JsonConvert.DeserializeObject<GoogleProfile>(userProfile);

            return RedirectToAction("Index", "Home");
        }
    }
}