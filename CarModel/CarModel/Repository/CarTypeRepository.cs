using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarModel.Models;

namespace CarModel.Repository
{
    public class CarTypeRepository : ICarTypeRepository
    {
        private readonly CarContext _carContext;

        public CarTypeRepository(CarContext carContext)
        {
            _carContext = carContext;
        }
        public IEnumerable<CarType> CarTypes => _carContext.CarType;

        public void AddCarTypeToDb(CarType newCarType)
        {
            _carContext.CarType.Add(newCarType);
            _carContext.SaveChanges();
        }
        public void DeleteCarType(int id)
        {
            var removeCarType = _carContext.CarType.Find(id);
            _carContext.CarType.Remove(removeCarType);
            _carContext.SaveChanges();
        }
    }
}
