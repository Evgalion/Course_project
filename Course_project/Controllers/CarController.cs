using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Course_project.DAL.Interfaces;
using Course_project.Service.Implementations;
using Course_project.Service.Interfaces;
using System.Threading.Tasks;
using Course_project.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Course_project.Domain.ViewModels.Car;
using System;
using System.Linq;

namespace Course_project.Controllers
{
    public class CarController : Controller
    {

        private readonly ICarService _carService;

        public CarController(ICarService CarService)
        {
            _carService = CarService; 
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response = await _carService.GetCars();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data.ToList());
            }
            return RedirectToAction("Error");
        }

        [HttpGet]
        public async Task<IActionResult> GetCar(int id)
        {
            var response = await _carService.GetCar(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

    }
}
