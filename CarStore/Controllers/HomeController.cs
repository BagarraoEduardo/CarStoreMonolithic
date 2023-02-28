using CarStore.Business.Interface;
using CarStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics;

namespace CarStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarStoreService _service;

        public HomeController(ICarStoreService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var cars = _service.GetAllCars();

            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}