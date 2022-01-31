using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIANS.Models;

namespace DIANS.Controllers
{
    public class HomeController : Controller
       
    {
        private DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bars()
        {
            return View(db.bars.ToList());
        }

        public ActionResult Restaurants()
        {
            return View(db.restaurants.ToList());
        }
    }
}