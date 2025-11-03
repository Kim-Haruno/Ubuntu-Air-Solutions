using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Ubuntu_Air_Solutions.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
