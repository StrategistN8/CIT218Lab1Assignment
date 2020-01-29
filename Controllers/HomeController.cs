using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIT218Lab1Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "As the industry leader in space resource acquisition, we at the Post Terran Mining Corperation strive to deliver high yields and innovative solutions to modern material needs." +
                " Our company employs some of the most advanced robotics ever created to minimize human risk while delivering quantity of valuable ores. Likewise, our research continues to push the limits of technology to continue the exploration of space.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}