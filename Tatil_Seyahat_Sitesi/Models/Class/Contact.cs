using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tatil_Seyahat_Sitesi.Models.Class
{
    public class Contact
    {
        [Key]

        public int ID { get; set; }

        [Required]
        public string AdSoyad { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Konu { get; set; }
        [AllowHtml] // "Mesaj" alanı HTML karakterlerini kabul edecek.
        [Required]
        public string Mesaj { get; set; }
      
      









    }
}