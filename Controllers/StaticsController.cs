using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Class;

namespace TicariOtomasyon.Controllers
{
    public class StaticsController : Controller
    {
        Context db = new Context();
        // GET: Statics
        public ActionResult Index()
        {
           // LINQ SORGULAR     

            var val1 = db.Currents.Count().ToString();  // Toplam Cari Sayısı
            ViewBag.v1 = val1; 
           
            var val2 = db.Products.Count().ToString();  // Toplam Ürün Sayısı
            ViewBag.v2 = val2; 
            
            var val3 = db.Employees.Count().ToString();     // Toplam Personel Sayısı
            ViewBag.v3 = val3; 
            
            var val4 = db.Categories.Count().ToString();    // Toplam Kategori Sayısı
            ViewBag.v4 = val4;
           
            var val5 = db.Products.Sum(x => x.ProductStock).ToString(); // Stokların Toplamı
            ViewBag.v5 = val5;
            
            var val6 = (from x in db.Products select x.ProductBrand).Distinct().Count().ToString(); // Toplam Marka sayısı
            ViewBag.v6 = val6; 
           
            var val7 = db.Products.Count(x => x.ProductStock<= 20).ToString();  // stok sayısı 20 den az olan kaç ürün var
            ViewBag.v7 = val7;
            
            var val8 = (from x in db.Products orderby x.SalePrice descending select x.ProductName).FirstOrDefault();    // Ürün Fiyatı En yüksek ürün
            ViewBag.v8 = val8;
              



            var val9 = (from x in db.Products orderby x.SalePrice ascending select x.ProductName).FirstOrDefault();     // ürün fiyatı en düşük ürün

            var val10 = db.Products.Count(x => x.ProductName == "Buzdolabı").ToString();    // ismi buzdolabı olan kaç ürünn var
            
              var val11 = db.Products.Count(x => x.ProductName == "Ütü").ToString();  // ismi ütü olan kaç ürünn var


            var val12 = db.Products.GroupBy(x => x.ProductBrand).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault(); // En çok satılan ürün markası
            ViewBag.v12 = val12;

            var val13 = db.Products.Where(u => u.ProductID == (db.Sales.GroupBy(x => x.ProductID).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault())).Select(k => k.ProductName).FirstOrDefault(); // en çok satılan ürün
            //var val13 = db.Products.GroupBy(x => x.ProductID).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.v13 = val13;

            var val14 = db.Sales.Sum(x => x.TotalPrice).ToString(); // kasadaki toplam para
            ViewBag.v14 = val14;

            DateTime today = DateTime.Today;
            var val15 = db.Sales.Count(x => x.Date == today).ToString();    //bugün kaç satış oldu
            ViewBag.v15 = val15;
           




            return View();
        }
    }
}