using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Class
{
    public class Oteller
    {
        public int Id { get; set; }                // Otelin ID'si
        public string Name { get; set; }           // Otelin Adı
        public string Location { get; set; }       // Konumu
        public int Price { get; set; }          // Fiyatı
        public string Description { get; set; }    // Açıklaması
        public string ImageUrl { get; set; }
    }
}