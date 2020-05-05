using ReactAspx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactAspx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // to create the database the first time, uncomment these 2 lines
          //  AppDbContext c = new AppDbContext();
          //  c.Database.CreateIfNotExists();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}