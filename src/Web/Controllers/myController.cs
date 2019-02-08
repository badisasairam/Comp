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
            return Context("You are having a great day!");
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
            var i = "<!DOCTYPE HTML><html><head><p> You are Awesome! </p></head><body>Have a great day</body></html>";
            return Context(i,"text/html");
        }

        public IActionResult MyApp()
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
