using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GreetingsInCSharp.Models;

namespace GreetingsInCSharp.Controllers
{
    public class HomeController : Controller
    {
        IGreetings greet;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IGreetings greet)
        {
            _logger = logger;
            this.greet = greet;
        }

        [HttpGet]
        public IActionResult Index()
        {
            greet.ClearMessages();
            return View(greet);
        }


        [HttpPost]
        public IActionResult Index(string nameVal, string languageVal)
        {
            greet.GetNameAndLanguage(nameVal, languageVal);
            greet.GreetName();

            return View(greet);
        }

        public IActionResult GreetedList() 
        {   
            return View(greet);
        }
 
        [Route("Home/GreetedList/{id}")]
        public IActionResult GreetsCountForName(string id)
        { 
            greet.SetSellectedNameValues(id);
            
            return View(greet); 
        }

        public IActionResult ClearGreets()
        { 
            greet.ClearGreets();
            
            return RedirectToAction("Index");
        }

        [Route("Home/GreetedList{id}")]
        public IActionResult RemoveName(string id)
        {
            greet.RemoveName(id);
            return Redirect("GreetedList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}