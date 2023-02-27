using CarStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarStore.Controllers
{
    public class LandingPageController : Controller
    {
        public LandingPageController(ILogger<LandingPageController> logger){ }

        public IActionResult Index()
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