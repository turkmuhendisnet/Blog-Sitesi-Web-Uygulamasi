using Blog_Sitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Sitesi.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext dbContext = new BlogContext(); 

        // GET: Home
        public ActionResult Index()
        {
            var bloglar = dbContext.Bloglar
                                            .Select(i=> new BlogModel()
                                            {
                                                Id=i.Id,
                                                Baslik=i.Baslik.Length>100?i.Baslik.Substring(0,100)+"...":i.Baslik,
                                                Aciklama=i.Aciklama,
                                                EklemeTarihi=i.EklemeTarihi,
                                                Anasayfa=i.Anasayfa,
                                                Onay=i.Onay,
                                                Resim=i.Resim

                                            })
                                             .Where(i => i.Onay == true && i.Anasayfa == true);

            //var a = from m in dbContext.Bloglar where m.Onay == true && m.Anasayfa == true select m; 

            return View(bloglar.ToList());
        }
    }
}