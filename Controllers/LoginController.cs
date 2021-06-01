using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        Context db = new Context();   
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }   
        [HttpPost]
        public ActionResult Index(Admin a)
        {
            var usr = db.Admins.FirstOrDefault(x => x.Username==a.Username && x.Password==a.Password);
            if(usr != null)
            {
                FormsAuthentication.SetAuthCookie(usr.Username, false);
                Session["Username"] = usr.Username.ToString();
                return RedirectToAction("Index", "Statics");
            }
            else
            {
                return RedirectToAction("Index","Login");

            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}