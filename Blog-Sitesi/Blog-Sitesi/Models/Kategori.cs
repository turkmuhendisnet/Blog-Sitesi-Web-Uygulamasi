using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Sitesi.Models
{
    public class Kategori
    {

        //default olarak Id ismini verdiğimizden PrimeryKey olarak anlaşıldı [Key] yazmaya gerek yok
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        
        //Bire çok ilişki 
        public List<Blog> Bloglar { get; set; }
    }
}