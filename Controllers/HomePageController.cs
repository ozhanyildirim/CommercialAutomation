using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicariOtomasyon.Controllers
{
    [AllowAnonymous]
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }
        public ActionResult ProductsCharger()
        {
            return View();
        }
        public ActionResult ProductsBattery()
        {
            return View();
        }
        public ActionResult ProductsHeadset()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }

    }
}