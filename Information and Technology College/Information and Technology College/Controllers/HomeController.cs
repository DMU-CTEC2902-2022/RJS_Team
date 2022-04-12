using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DebuggerCollege.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What we do.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in Touch.";

            return View();
        }
    }
}