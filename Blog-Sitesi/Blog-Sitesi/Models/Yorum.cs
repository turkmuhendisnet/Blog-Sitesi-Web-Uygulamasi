using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Sitesi.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad{ get; set; }
        public string Mesaj { get; set; }
        public DateTime YorumTarihi { get; set; }

        public int BlogId { get; set; }

        public Blog Blogu { get; set; }
    }
}