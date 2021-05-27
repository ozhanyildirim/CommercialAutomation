using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductBrand { get; set; } //marka
        public short ProductStock { get; set; } //stok
        public decimal PurchasePrice { get; set; } //alış fiyat
        public decimal SalePrice { get; set; } //satış fiyat
        public bool Status { get; set; } // ürün durumu stok azalınca bildirim yapıyor

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string ProductImage { get; set; } // ürün resmi

        public int CategoriesID { get; set; }
        public virtual Categories Categories { get; set; } // bir ürünün yalnız 1 kategorisi olabilir
        public ICollection<Sales> Sales { get; set; }
    }
}