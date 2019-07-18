using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using test_anastasiia_prygun.Models;

namespace test_anastasiia_prygun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Summary()
        {
            ViewData["Message"] = "Hello world!";

            return View();
        }

        public IActionResult Peers()
        {
            return View();
        }

        public ActionResult GetCurrentTime()
        {
            String currentTime = DateTime.Now.ToString("F");
            return Json(currentTime);
        }

        public IActionResult Exchange()
        {
            return View();
        }

        public IActionResult BlockTrades()
        {
            return View();
        }

        public IActionResult MediaCoverage()
        {
            return View();
        }

        public IActionResult Previous()
        {
            return View();
        }

        public IActionResult Charts()
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
