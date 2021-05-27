using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;


namespace TicariOtomasyon.Controllers
{
    public class CurrentController : Controller
    {
        Context db = new Context();

        // GET: Current
        public ActionResult Index()
        {
            var crt = db.Currents.Where(x => x.Status == true).ToList();
            return View(crt);
        }
        [HttpGet]
        public ActionResult AddCurrent()           // Cari Ekle Sayfası
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCurrent(Current c)       // Cari Ekleme Post Etme
        {
            c.Status = true;
            db.Currents.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCurrent(int id)      // Cari Silme İşlemi
        {
            var del = db.Currents.Find(id);
            del.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FindCurrent(int id)        //    Cari Getirme işlemi
        {
            var edit = db.Currents.Find(id);
            return View("FindCurrent", edit);
        }

        public ActionResult EditCurrent(Current c)        //  Cari Edit işlemi
        {
            if (!ModelState.IsValid)
            {
                return View("FindCurrent");
            }
            var a = db.Currents.Find(c.CurrentID);
            a.CurrentName = c.CurrentName;
            a.CurrentSurname = c.CurrentSurname;
            a.CurrentMail = c.CurrentMail;
            a.CurrentCity = c.CurrentCity;
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult SalesHistory(int id)
        {
            var hst = db.Sales.Where(x => x.CurrentID == id).ToList();
            var dep = db.Currents.Where(x => x.CurrentID == id).Select(y => y.CurrentName + "  " + y.CurrentSurname).FirstOrDefault();
            ViewBag.dp = dep;
            return View(hst);
            
        }
    }
}