using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_Sitesi.Models
{
    public class BlogContext:DbContext
    {

        //Veri tabanı ismini burada "base("BlogDataBase")" ve webconfig de connectionsitring olarak belirte biliriz
        public BlogContext():base("BlogDataBase")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        // tablo isimleri
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

    }
}