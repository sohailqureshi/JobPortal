﻿using System.Web.Mvc;

namespace JobPortal.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult PrivacyPolicy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult TermsConditions()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Candidates()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Companies()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        public ActionResult Sitemap()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JobsIn()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JobPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JobsList()
        {
            
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
