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

            return View(dbContext.Bloglar.ToList());
        }
    }
}