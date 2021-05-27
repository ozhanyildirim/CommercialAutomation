using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class ReceiptTrans   // fatura işlemleri
    {
        [Key]
        public int ReceiptTransID { get; set; } // fatura işlemleri id
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string Explain { get; set; } // açıklama
        public int Piece { get; set; } //miktar
        public decimal UnitPrice { get; set; } // birim fiyat
        public decimal Amount { get; set; } // Tutar

        public Receipt Receipt { get; set; } // fatura işlemi 1 fatura için
    }
}