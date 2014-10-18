using Core;
using ONETUG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONETUG.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            return PartialView(GroupSettings.Instance);
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Join()
        {
            return View();
        }
    }
}
