using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class ProductDetailController : Controller
    {
        Context db = new Context();
        
        // GET: ProductDetail
        public ActionResult Index()
        {
            //  var val = db.Products.Where(x => x.ProductID == 1).ToList();

            Class1 class1 = new Class1();
            class1.Val1 = db.Products.Where(x => x.ProductID == 1).ToList();
            class1.Val2 = db.ProductDescriptions.Where(z => z.DetailID == 1).ToList();
            class1.Val3 = db.Sales.ToList();

            return View(class1);
        }
    }
}