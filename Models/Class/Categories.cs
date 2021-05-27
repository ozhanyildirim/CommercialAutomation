using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Categories
    {
        [Key]
        public int CategoriesID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoriesName { get; set; }

        public ICollection<Product> Products { get; set; }  // kategori 1 den çok ürün tutabilir

    }
}