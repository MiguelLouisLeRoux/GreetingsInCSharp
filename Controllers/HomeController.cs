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

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
    
            return View(greet);
        }


        [HttpPost]
        public IActionResult Index(string nameVal, string languageVal)
        {

            greet.GetNameAndLanguage(nameVal, languageVal);
            greet.GreetName();

            Console.WriteLine(greet.theGreeting);
            Console.WriteLine(greet.count);

            return View(greet);
        }

        public IActionResult Greeted()
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
