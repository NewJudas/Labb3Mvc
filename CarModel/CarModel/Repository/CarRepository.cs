using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarModel.Models;
using Microsoft.EntityFrameworkCore;

namespace CarModel.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public IEnumerable<Car> Cars
        {
            get
            {
                return _carContext.Cars.Include(c => c.CarType);
            }
        }

        public void AddCarToDb(Car newCar)
        {
            _carContext.Cars.Add(newCar);
            _carContext.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var removeCar = _carContext.Cars.Find(id);
            _carContext.Cars.Remove(removeCar);
            _carContext.SaveChanges();
        }

        public Car Edit(Car updatedCar)
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
