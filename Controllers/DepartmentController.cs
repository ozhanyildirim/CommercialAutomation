using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class DepartmentController : Controller
    {
        Context db = new Context();

        // GET: Department
        public ActionResult Index()
        {
            var values = db.Departments.Where(x=>x.Status==true).ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult AddDep()           // Kategori Ekle Sayfası
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDep(Department c)       // Kategori Ekleme POst
        {
            c.Status = true;
            db.Departments.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteDep(int id)      // departman Silme İşlemi
        {
            var del = db.Departments.Find(id);
            del.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FindDep(int id)        //    departman Getirme işlemi
        {
            var edit = db.Departments.Find(id);
            return View("FindDep", edit);
        }

        public ActionResult EditDep(Department c)        //  departman Edit işlemi
        {
            var ctg = db.Departments.Find(c.DepartmentID);
            ctg.DepartmentName = c.DepartmentName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepDet(int id)          // departman detay sayfası
        {
            var values = db.Employees.Where(x => x.DepartmentID == id).ToList();
            var dpt = db.Departments.Where(x => x.DepartmentID == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.dp = dpt;
            return View(values);
        }

        public ActionResult EmployeeSales(int id)
        {
            var emp = db.Sales.Where(x => x.EmployeeID == id).ToList();
            var dep = db.Employees.Where(x => x.EmployeeID == id).Select(y => y.EmployeeName + "  " + y.EmployeeSurname).FirstOrDefault();
            ViewBag.dp = dep;
            return View(emp);
        }
    }

   

}