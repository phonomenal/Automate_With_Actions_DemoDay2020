using Microsoft.AspNetCore.Mvc;
using ReadingTime3.Web.Models;
using System;
using System.Diagnostics;

namespace ReadingTime3.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "This demo doesn't save any data, so we're all OK.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
