using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Sales  //satış hareketleri
    {
        public int SalesID { get; set; }    //satış id
        public DateTime Date { get; set; }  //tarih 
        public int Piece { get; set; }  //adet
        public decimal Price { get; set; }  //fiyat
        public decimal TotalPrice { get; set; } //toplam fiyat
        public int ProductID { get; set; }
        public int CurrentID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Product Products { get; set; }
        public virtual Current Currents { get; set; }
        public virtual Employee Employees { get; set; }
    }
}