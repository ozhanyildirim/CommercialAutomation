using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class EmployeeController : Controller
    {
        Context db = new Context();

        // GET: Employee
        public ActionResult Index()

        {
            var val = db.Employees.ToList();
            return View(val);
        }

        [HttpGet]
        public ActionResult AddEmp()           // Yeni Personel Ekle Sayfası
        {
            List<SelectListItem> val = (from x in db.Departments.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.DepartmentName,
                                            Value = x.DepartmentID.ToString()
                                        }).ToList();

            ViewBag.val1 = val;     // viewe değer taşıma
            return View();
        }
        [HttpPost]
        public ActionResult AddEmp(Employee c)       // Personel Ekleme POst
        {
            db.Employees.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FindEmp(int id)        //    Personel Getirme işlemi
        {
            List<SelectListItem> val = (from x in db.Departments.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.DepartmentName,
                                            Value = x.DepartmentID.ToString()
                                        }).ToList();

            ViewBag.val1 = val;     // viewe değer taşıma
            var edit = db.Employees.Find(id);
            return View("FindEmp", edit);
        }

        public ActionResult EditEmp(Employee c)        //  Personel Edit işlemi
        {
            var p = db.Employees.Find(c.EmployeeID);
            p.EmployeeID = c.EmployeeID;
            p.EmployeeImage = c.EmployeeImage;
            p.EmployeeName = c.EmployeeName;
            p.EmployeeSurname = c.EmployeeSurname;
            p.DepartmentID = c.DepartmentID;
          
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}