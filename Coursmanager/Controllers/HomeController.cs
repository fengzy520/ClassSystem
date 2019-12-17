using Coursemanager.Models;
using Coursmanager.Filters;
using Coursmanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C
{
    [RequireAuthentication]
    [ActionResultExceptionFiler]
    public class HomeController : Controller
    {
        private CourseManagerContext db = new CourseManagerContext();
        public ActionResult Index()
        {
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

        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo();
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }
        public ActionResult Sidebar()
        {
            var sidebar = db.Sidebar.ToList();
            ViewBag.Sidebar = sidebar;
            return PartialView("~/Views/Shared/Sidebar.cshtml");
        }

        
    }
}