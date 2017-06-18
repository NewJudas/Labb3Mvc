using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarModel.ViewModels;
using CarModel.Models;
using CarModel.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarModel.Controllers
{
    public class CarTypeController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarTypeRepository _carTypeRepository;

        public CarTypeController(ICarRepository carRepository, ICarTypeRepository carTypeRepository)
        {
            _carRepository = carRepository;
            _carTypeRepository = carTypeRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewCarType()
        {
            CarViewModel carViewModel = new CarViewModel();
            carViewModel.CarTypes = _carTypeRepository.CarTypes;
            return View(carViewModel);
        }
        public IActionResult AddCarType(string engine)
        {
            var newEngine = new CarType { Enginge = engine };

            _carTypeRepository.AddCarTypeToDb(newEngine);

            return RedirectToAction("Index", "Car");
        }
        public IActionResult DeleteCarType()
        {
            CarViewModel carViewModel = new CarViewModel();
            carViewModel.CarTypes = _carTypeRepository.CarTypes;
            return View(carViewModel);
        }
        public IActionResult Delete(int id)
        {
            _carTypeRepository.DeleteCarType(id);

            return RedirectToAction("Index", "Car");
        }
    }
}
