using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Admin  // admin sınıfı
    {
        [Key]
        public int AdminID { get; set; }    //admin id
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Username { get; set; }   //kullanıcı adı
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Password { get; set; }   //şifre
        [Column(TypeName = "Varchar")]
        [StringLength(1)]
        public string Authory { get; set; }    //yetki
    }
}