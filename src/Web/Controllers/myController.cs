using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class myController : Controller
    {
        public IActionResult showIndex()
        {
            return Content("You are having a great day!");
        }

        public IActionResult showPrivacy()
        {
            return Json(new
            {
                name = " Sairam Badisa"
            });
        }

        public IActionResult showContact()
        {
            var i = "<!DOCTYPE HTML><html><head><p> positive quotations </p></head><body> You're Awesome Have a great day</body></html>";
            return Content(i,"text/html");
        }

        public IActionResult MyComp()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
