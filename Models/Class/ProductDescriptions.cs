using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class ProductDescriptions
    {
        [Key]
        public int DetailID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(3000)]
        public string ProductDescription { get; set; }
    }
}