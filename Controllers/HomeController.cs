using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsumingAPIDotNetMVCBootstrap.Models;
using ConsumingAPIDotNetMVCBootstrap.Services;

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
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/megasena/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult LotoFacil()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/lotofacil/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Quina()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/quina/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult LotoMania()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/lotomania/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult TimeMania()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/timemania/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult DuplaSena()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/duplasena/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Federal()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/federal/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Loteca()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/loteca/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        public IActionResult DiaDeSorte()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/diadesorte/lasted");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            DataResponse serviceData = new ServiceDataResponse().GetDataResponse("");
            Console.WriteLine(serviceData.Data[0].TipoJogo);
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
