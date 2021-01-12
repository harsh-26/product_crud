using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace product_crud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            Console.WriteLine("Hellosir");
            Console.WriteLine("check mhhhbhby work aayush");
            return View();
        }
    }
}
