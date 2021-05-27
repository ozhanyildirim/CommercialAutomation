using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Expenses   //Giderler
    {
        [Key]
        public int ExpensesID { get; set; } //giderler id
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string ExpensesExplain { get; set; } // açıklama
        public DateTime Date { get; set; } // tarih

        public decimal Price { get; set; } // tutar

    }
}