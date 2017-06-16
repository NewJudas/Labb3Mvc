using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarModel.ViewModels;
using CarModel.Repository;
using CarModel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarModel.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarTypeRepository _carTypeRepository;

        public CarController(ICarRepository carRepository, ICarTypeRepository carTypeRepository)
        {
            _carRepository = carRepository;
            _carTypeRepository = carTypeRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CarViewModel carViewModel = new CarViewModel();
            carViewModel.Cars = _carRepository.Cars;
            return View(carViewModel);
        }
        public IActionResult AddCarInfo()
        {
            CarViewModel carViewModel = new CarViewModel();
            carViewModel.CarTypes = _carTypeRepository.CarTypes;
            return View(carViewModel);
        }
        public IActionResult AddCar(string brand, string regNr,string carModel, int carTypeId)
        {
            var newCar = new Car { CarBrand = brand, RegNr = regNr,CarModel= carModel, CarTypeId = carTypeId };

            _carRepository.AddCarToDb(newCar);
            return RedirectToAction("Index", "Car");
        }

        public IActionResult DeleteCar()
        {
            CarViewModel carViewModel = new CarViewModel();
            carViewModel.Cars = _carRepository.Cars;
            return View(carViewModel);
        }
        public IActionResult Delete(int id)
        {
            _carRepository.DeleteCar(id);

            return RedirectToAction("Index", "Car");
        }

        public IActionResult Edit()
        {
            CarViewModel carViewModel = new CarViewModel();
            carViewModel.Cars = _carRepository.Cars;
            return View(carViewModel);
        }
        public IActionResult EditCar(int id, string brand, string regNr,string carModel, int carTypeId)
        {
            var updatingCar = _carRepository.GetCarById(id);

            updatingCar.CarBrand = brand;
            updatingCar.RegNr = regNr;
            updatingCar.CarModel = carModel;
            updatingCar.CarTypeId = carTypeId;

            _carRepository.Edit(updatingCar);
            return RedirectToAction("Index", "Car");
        }
    }
}
