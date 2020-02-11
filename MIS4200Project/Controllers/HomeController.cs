using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4200Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS4200 Description Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to reach out with me with an email or a text. ";

            return View();
        }
    }
}