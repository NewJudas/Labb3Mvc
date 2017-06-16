using CarModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel.Repository
{
    public interface ICarTypeRepository
    {
        void AddCarTypeToDb(CarType newEngine);
        void DeleteCarType(int id);
        IEnumerable<CarType> CarTypes { get; }
    }
}
