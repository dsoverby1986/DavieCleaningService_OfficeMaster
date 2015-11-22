using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavieCleaningService_OfficeMaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CurrentMenuItem = "Home";
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.CurrentMenuItem = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.CurrentMenuItem = "Contact";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.CurrentMenuItem = "Team";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.CurrentMenuItem = "lServices";

            return View();
        }
    }
}