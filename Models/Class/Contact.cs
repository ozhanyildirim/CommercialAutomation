using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Class
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Username { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string Message { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(12)]
        public string Phone { get; set; }

    }
}