using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Controllers;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class CategoriesController : Controller
    {
      
        Context db = new Context();
        // GET: Categories
 
        public ActionResult Index()
        {
            var values = db.Categories.ToList();
            
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()           // Kategori Ekle Sayfası
        {
               return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Categories c)       // Kategori Ekleme POst
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteCategory(int id)      // Kategori Silme İşlemi
        {
            var del = db.Categories.Find(id);
            db.Categories.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditCategory(int id)        //    Kategori Getirme işlemi
        {
            var edit = db.Categories.Find(id);
            return View("EditCategory",edit);
        }

        public ActionResult AfterEditCategory(Categories c)        //  Kategori Edit işlemi
        {
            var ctg = db.Categories.Find(c.CategoriesID);
            ctg.CategoriesName = c.CategoriesName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}