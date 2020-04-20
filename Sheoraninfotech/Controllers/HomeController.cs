using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheoraninfotech.Controllers
{
    

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
        [AllowAnonymous]
        [ActionName("About-US")]
        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult elements()
        {
            return View();
        }
        public ActionResult features()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult pricing()
        {
            return View();
        }
        public ActionResult singleblog()
        {
            return View();
        }
        [AllowAnonymous]
        [ActionName("Website-Development")]
        public ActionResult websitedevelopment()
        {
            return View("websitedevelopment");
        }
        [AllowAnonymous]
        [ActionName("Android-App-Development")]
        public ActionResult AndroidAppDevelopment()
        {
            return View("AndroidAppDevelopment");
        }
        [AllowAnonymous]
        [ActionName("IOS-Development")]
        public ActionResult IOSDevelopment()
        {
            return View("IOSDevelopment");
        }
        [AllowAnonymous]
        [ActionName("Desktop-Application-Development")]
        public ActionResult DesktopApplicationDevelopment()
        {
            return View("DesktopApplicationDevelopment");
        }
        [AllowAnonymous]
        [ActionName("Digital-Marketing")]
        public ActionResult DigitalMarketing()
        {
            return View("DigitalMarketing");
        }
    }
}