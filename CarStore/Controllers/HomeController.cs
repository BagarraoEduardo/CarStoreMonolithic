using CarStore.Business.Interface;
using CarStore.Models;
using CarStore.ViewModels;
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
            ViewData["Title"] = "CarStore";
            ViewData["Heading"] = "Choose your dream car!";

            var cars = _service.GetAllCars();
            var carsCount = cars.Count();

            ViewBag.CountText = "Available cars: ";
            ViewBag.Count = carsCount;

            var carListViewModel = new CarListViewModel() 
            {
                Cars = cars,
                CurrentCarType = "current Car Type"
            };

            return View(carListViewModel);
        }
    }
}