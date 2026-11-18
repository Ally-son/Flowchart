using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flowchart.Controllers
{
    public class HomeController : Controller
    {
      

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

    }
}