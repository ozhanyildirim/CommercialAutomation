using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Receipt
    {
        [Key]
        public int ReceiptID { get; set; }      // fatura id

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string ReceiptSerialNo { get; set; } // fatura seri no

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ReceiptNo { get; set; }   // fatura sıra no

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string TaxDepartment { get; set; } //vergi dairesi

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Seller { get; set; } // teslim eden

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Receiver { get; set; } // teslim alan

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string Time { get; set; } // saat
        public DateTime Date { get; set; } // tarih

        public decimal Total { get; set; }

        public ICollection<ReceiptTrans> ReceiptTrans { get; set; } // 1 faturada 1den çok işlem olabilir



    }
}