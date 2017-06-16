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
            throw new NotImplementedException();
        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
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
