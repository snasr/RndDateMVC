using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RndDateMVC.Controllers
{
    public class RndDateController : Controller
    {
        // GET: RndDate
        public ActionResult Index()
        {
            ViewBag.RndDate = RandomDay();
            return View();
        }
        
        
        public DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}