using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class ReceiptController : Controller
    {
        Context db = new Context();
        // GET: Receipt
        public ActionResult Index()
        {
            var list = db.Receipts.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult AddRec()           // fatura Ekle Sayfası
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRec(Receipt c)       // fatura Ekleme Post Etme
        {
            db.Receipts.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FindRec(int id)        //    fatura Getirme işlemi
        {
            var edit = db.Receipts.Find(id);
            return View("FindRec", edit);
        }

        public ActionResult EditRec(Receipt c)        //  fatura Edit işlemi
        {

            var a = db.Receipts.Find(c.ReceiptID);
            a.ReceiptNo = c.ReceiptNo;
            a.ReceiptSerialNo = c.ReceiptSerialNo;
            a.Receiver = c.Receiver;
            a.Seller = c.Seller;
            a.TaxDepartment = c.TaxDepartment;
            a.Time = c.Time;
            a.Total = c.Total;
            a.Date = c.Date;
           
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult RecDet(int id)          // fatura detay sayfası
        {
            var values = db.ReceiptTrans.Where(x => x.ReceiptID == id).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewReceiptTrans()           // fatura kalemi Ekle Sayfası
        {
            return View();
        }
        public ActionResult NewReceiptTrans(ReceiptTrans c)          // fatura kalem 
        {
            db.ReceiptTrans.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}