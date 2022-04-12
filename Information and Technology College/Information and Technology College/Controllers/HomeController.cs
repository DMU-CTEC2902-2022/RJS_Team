using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DebuggerCollege.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: About
        public ActionResult About()
        {
            ViewBag.Message = "What we do.";

            return View();
        }

        // GET: Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Get in Touch.";

            return View();
        }
    }
}