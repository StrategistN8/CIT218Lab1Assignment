using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIT218Lab1Assignment.Controllers
{
    public class BotController : Controller
    {
        
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult NewBot(int quantity, string botName, string mineSys, string botFunc )
        {
            ViewBag.Message = "Robot Name: " + botName + "\n";
            ViewBag.Message += " Robot Function: " + botFunc + "\n";
            ViewBag.Message += " Quantity Requested: " + quantity + "\n";
            ViewBag.Message += " Mine System: " + mineSys + "\n";


            return View("ConfirmBotRequest");
        }

        public ActionResult NewBot(string type)
        {
            string t = HttpUtility.HtmlEncode(type);

            if (t == "customer")
            {

                return RedirectToAction("Contact", "Home");
            }

            else
            {
                return View("BotRequest");
            }

            
        }

    }
}