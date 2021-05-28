using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class SalesController : Controller
    {
        Context db = new Context();
        // GET: Sales
        public ActionResult Index()
        {
            var val = db.Sales.ToList();
            return View(val);
        }

        [HttpGet]
        public ActionResult AddSales()           // Yeni Satış Ekle Sayfası
        {
            List<SelectListItem> val = (from x in db.Products.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.ProductName + " " + x.PurchasePrice + " tl",
                                            Value = x.ProductID.ToString()
                                        }).ToList();

            ViewBag.val1 = val;     // viewe değer taşıma

            List<SelectListItem> emp  = (from x in db.Employees.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.EmployeeName + " " + x.EmployeeSurname,
                                            
                                            Value = x.EmployeeID.ToString()
                                        }).ToList();

            ViewBag.val2 = emp;     // viewe değer taşıma

            List<SelectListItem> crt = (from x in db.Currents.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CurrentName + " " + x.CurrentSurname,
                                            Value = x.CurrentID.ToString()
                                        }).ToList();

            ViewBag.val3 = crt;     // viewe değer taşıma

            return View();
        }
        [HttpPost]
        public ActionResult AddSales(Sales c)       // Personel Ekleme POst
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Sales.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FindSales(int id)        //    Personel Getirme işlemi
        {
            List<SelectListItem> val = (from x in db.Products.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.ProductName,
                                            Value = x.ProductID.ToString()
                                        }).ToList();

            ViewBag.val1 = val;     // viewe değer taşıma

            List<SelectListItem> emp = (from x in db.Employees.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.EmployeeName + " " + x.EmployeeSurname,

                                            Value = x.EmployeeID.ToString()
                                        }).ToList();

            ViewBag.val2 = emp;     // viewe değer taşıma

            List<SelectListItem> crt = (from x in db.Currents.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CurrentName + " " + x.CurrentSurname,
                                            Value = x.CurrentID.ToString()
                                        }).ToList();

            ViewBag.val3 = crt;              // viewe değer taşıma


            var edit = db.Sales.Find(id);
            return View("FindSales", edit);
        }

        public ActionResult EditSales(Sales c)        //  Satış Edit işlemi
        {
            var p = db.Sales.Find(c.SalesID);
            p.Piece = c.Piece;
            p.Price = c.Price;
            p.TotalPrice = c.TotalPrice;
            p.Date = c.Date;
            p.CurrentID = c.CurrentID;
            p.ProductID = c.ProductID;
            p.EmployeeID = c.EmployeeID;

           
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SalesDet(int id)
        {
            var values = db.Sales.Where(x => x.SalesID == id).ToList();
            return View(values);
        }

        public ActionResult PrintSales(int id)
        {
            var values = db.Sales.Where(x => x.SalesID == id).ToList();
            return View(values);
        }

    }
}