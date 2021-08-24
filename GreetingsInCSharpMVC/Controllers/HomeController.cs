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
        GreetingsModel greet = new GreetingsModel();
        GreetingsMethodsModel greetMethods = new GreetingsMethodsModel();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            greetMethods.ClearMessages();
            return View(greet);
        }


        [HttpPost]
        public IActionResult Index(string nameVal, string languageVal)
        {
            greetMethods.GetNameAndLanguage(nameVal, languageVal);
            greetMethods.GreetName();

            return View(greet);
        }

        public IActionResult GreetedList() 
        {   
            return View(greet);
        }
 
        [Route("Home/GreetedList/{id}")]
        public IActionResult GreetsCountForName(string id)
        { 
            greetMethods.SetSellectedNameValues(id);
            
            return View(greet); 
        }

        public IActionResult ClearGreets()
        { 
            greetMethods.ClearGreets();
            
            return RedirectToAction("Index");
        }

        [Route("Home/GreetedList{id}")]
        public IActionResult RemoveName(string id)
        {
            greetMethods.RemoveName(id);
            return Redirect("GreetedList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}