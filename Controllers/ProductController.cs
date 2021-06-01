using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
  
    public class ProductController : Controller
    {
        Context db = new Context();
        // GET: Product
        public ActionResult Index()
        {
            var product = db.Products.Where(x => x.Status == true).ToList();
            return View(product);
        }
       
        
        [HttpGet]
        public ActionResult AddProduct()           // Kategori Ekle Sayfası
        {
            List<SelectListItem> val = (from x in db.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CategoriesName,
                                            Value = x.CategoriesID.ToString()
                                        }).ToList();

            ViewBag.val1 = val;     // viewe değer taşıma

            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product c)       // Kategori Ekleme POst
        {
            db.Products.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)      // Kategori Silme İşlemi
        {
            var del = db.Products.Find(id);
            del.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult GetProduct(int id)        //    Kategori Getirme işlemi
        {
            List<SelectListItem> val = (from x in db.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CategoriesName,
                                            Value = x.CategoriesID.ToString()
                                        }).ToList();

            ViewBag.val1 = val;     // viewe değer taşıma
            var edit = db.Products.Find(id);
            return View("GetProduct", edit);
        }

        public ActionResult EditProduct(Product c)        //  Kategori Edit işlemi
        {
            var p = db.Products.Find(c.ProductID);
            p.ProductID = c.ProductID;
            p.ProductBrand = c.ProductBrand;
            p.ProductImage = c.ProductImage;
            p.ProductName = c.ProductName;
            p.ProductStock = c.ProductStock;
            p.PurchasePrice = c.PurchasePrice;
            p.SalePrice = c.SalePrice;
            p.Sales = c.Sales;
            p.Status = c.Status;
            p.CategoriesID = c.CategoriesID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ProductList()
        {
            var values = db.Products.ToList();
            return View(values);
        }
    }
}