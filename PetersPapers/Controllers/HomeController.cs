using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetersPapers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("./././Angular/AngularPeters/src/index.html");
        }
    }
}
