using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var admin = db.Admins.ToList();
            return View(admin);
        } 
        public ActionResult DeleteAdmin(int id)
        {
            var del = db.Admins.Find(id);
            db.Admins.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetAdmin(int id)
        {
            var edit = db.Admins.Find(id);
            return View("GetAdmin", edit);
        }
        public ActionResult EditAdmin(Admin c)
        {
            var admin = db.Admins.Find(c.AdminID);
            admin.Username = c.Username;
            admin.Password = c.Password;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddAdmin()           // Kullanıcı Ekle Sayfası
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin c)
        {
            db.Admins.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
}
}