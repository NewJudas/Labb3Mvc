using CarModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel.ViewModels
{
    public class CarViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<CarType> CarTypes { get; set; }
    }
}
