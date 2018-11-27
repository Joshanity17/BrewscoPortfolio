using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrewscoPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Home = true;
            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Home = false;
            return View();
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Home = false;
            return View();
        }


        public ActionResult Cart()
        {
            ViewBag.Home = false;
            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Home = false;
            return View();
        }

        public ActionResult BlogDetail()
        {
            ViewBag.Home = false;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Home = false;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Home = false;
            return View();
        }
    }
}