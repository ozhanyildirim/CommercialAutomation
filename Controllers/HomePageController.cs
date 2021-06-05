using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    [AllowAnonymous]
    public class HomePageController : Controller
    {
        Context db = new Context();

            // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Products()  // Telefon Bölümü
        {
            var values = db.Products.Where(x => x.Status == true && x.Categories.CategoriesName == "Cep Telefonu").ToList();
            return View(values);
        
        }
        public ActionResult ProductsCharger()   // Şarj Cihazı
        {
            var values = db.Products.Where(x => x.Status == true && x.Categories.CategoriesName == "Şarj Cihazı").ToList();
            return View(values);
        }
        public ActionResult ProductsBattery()
        {
            var values = db.Products.Where(x => x.Status == true && x.Categories.CategoriesName == "Batarya").ToList();
            return View(values);
        }
        public ActionResult ProductsHeadset()
        {
            var values = db.Products.Where(x => x.Status == true && x.Categories.CategoriesName == "Kulaklık").ToList();
            return View(values);
        }


        public ActionResult Contact()
        {
            return View();
        }

    }
}