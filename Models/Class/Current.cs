using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Class
{
    public class Current // Cari
    {
        [Key]
        public int CurrentID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50,ErrorMessage ="En Fazla 50 karakter kullanabilirsin!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz !")]

        public string CurrentName { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En Fazla 50 karakter kullanabilirsin !")]
        [Required(ErrorMessage ="Bu alanı boş geçemezsiniz !")]
        public string CurrentSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En Fazla 30 karakter kullanabilirsin!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz !")]

        public string CurrentCity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "En Fazla 100 karakter kullanabilirsin!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz !")]

        public string CurrentMail { get; set; }

        public bool Status { get; set; }

        public ICollection<Sales> Sales { get; set; }

    }
}