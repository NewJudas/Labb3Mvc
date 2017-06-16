using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarModel.Models;

namespace CarModel.Repository
{
    public class CarTypeRepository : ICarTypeRepository
    {
        public IEnumerable<CarType> CarTypes => throw new NotImplementedException();

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
