using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsumingAPIDotNetMVCBootstrap.Models;

namespace ConsumingAPIDotNetMVCBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MegaSena()
        {
            return View();
        }

        public IActionResult LotoFacil()
        {
            return View();
        }

        public IActionResult Quina()
        {
            return View();
        }

        public IActionResult LotoMania()
        {
            return View();
        }

        public IActionResult TimeMania()
        {
            return View();
        }

        public IActionResult DuplaSena()
        {
            return View();
        }

        public IActionResult Federal()
        {
            return View();
        }

        public IActionResult Loteca()
        {
            return View();
        }

        public IActionResult DiaDeSorte()
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
