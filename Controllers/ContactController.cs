using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class ContactController : Controller
    {
        Context db = new Context();
        // GET: Contact
        public ActionResult Index()
        {
            var msg = db.Contacts.ToList();
            return View(msg);
        }  
        public ActionResult DeleteContact(int id)
        {
            var del = db.Contacts.Find(id);
            db.Contacts.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}