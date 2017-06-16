using CarModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }
        void AddCarToDb(Car newCar);
        Car GetCarById(int carId);
        void DeleteCar(int id);
        Car Edit(Car updatedCar);
    }
}
