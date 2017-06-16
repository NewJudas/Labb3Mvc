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

        public void AddCarTypeToDb(CarType newEngine)
        {
            throw new NotImplementedException();
        }

        public void DeleteCarType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
