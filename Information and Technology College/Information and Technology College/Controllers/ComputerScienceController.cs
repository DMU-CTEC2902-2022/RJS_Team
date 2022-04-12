using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Information_and_Technology_College.Controllers
{
    public class ComputerScienceController : Controller
    {
        // GET: ComputerScience
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Modules()
        {
            return View();
        }
    }
}