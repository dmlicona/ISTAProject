using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_AkA_CakePops_Website.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Project_AkA_CakePops_Website.Controllers
{
    public class HomeController : Controller
    {
        //database
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration config)
        {
            configuration = config;
        }
        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "The idea behind the baking...";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Call or email us!";

            return View();
        }

        public IActionResult Privacy()
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
