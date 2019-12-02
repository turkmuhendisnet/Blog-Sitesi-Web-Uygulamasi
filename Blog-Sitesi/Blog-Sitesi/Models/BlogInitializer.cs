using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_Sitesi.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Kategori> Kategoriler=new List<Kategori>()
            {
                new Kategori{ KategoriAdi="C# Programlama"},
                new Kategori{KategoriAdi="Asp.Net MVC"},
                new Kategori {KategoriAdi="Asp.Net WebForms"},
                new Kategori{KategoriAdi="C Programlama"}
                
            };

            foreach (var kategori in Kategoriler)
                context.Kategoriler.Add(kategori);

            context.SaveChanges();

            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog{Baslik="C# Overload",Aciklama="Overload nedir?",EklemeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="Overload bir medodun aynı isimde tekrar tekrar imzaları farklı olarak tanımlanmasıdır." ,Resim="1.jpg",KategoriId=1},

                new Blog{Baslik="MVC nedir?",Aciklama="MVC tanımı",EklemeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=false,Icerik="MVC model,view ve controller dosylarından oluşan projedir.",Resim="2.jpg",KategoriId=2},

                new Blog{Baslik="WebForms",Aciklama="WebForms nedir?",EklemeTarihi=DateTime.Now.AddDays(-15),Anasayfa=true, Onay=true,Icerik="WebForms Microsoft tarafından gelştirilen eski mimarierden olan bir web yazılım teklonojisidir.",Resim="3.jpg",KategoriId=3},

                new Blog{Baslik="Structures",Aciklama="Yapıların c programlamada kullanılması",EklemeTarihi=DateTime.Now.AddDays(-12),Anasayfa=true,Onay=false,Icerik="Yapıların tanımlanmaıs classlara benzer fakat farklılıklar göstere bilirler",Resim="4.jpg",KategoriId=4},

                new Blog{Baslik="Pointer",Aciklama="Pointerların c programlamada kullanılması",EklemeTarihi=DateTime.Now.AddDays(-12),Anasayfa=true,Onay=true ,Icerik="Pointerlar ramde verinin tututuğu adresi gösteren göstericilerdir.",Resim="7.jpg",KategoriId=4}

            };

            foreach (var blog in Bloglar)
                context.Bloglar.Add(blog);

            context.SaveChanges();

            List<Yorum> Yorumlar = new List<Yorum>(){

                new Yorum{Ad="Ali",Soyad="Çakır",YorumTarihi=DateTime.Now.Date,BlogId=1,Mesaj="Yazıyı Beğendim"},
                new Yorum{Ad="Samet",Soyad="Aybaba",YorumTarihi=DateTime.Now.Date,BlogId=2,Mesaj="Güzel  yaılmış"}

            };
            foreach (var yorum in Yorumlar)
                context.Yorumlar.Add(yorum);

            context.SaveChanges();

            base.Seed(context);

        }


    }
}