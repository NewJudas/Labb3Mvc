using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarModel.ViewModels;
using CarModel.Repository;

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
    }
}
