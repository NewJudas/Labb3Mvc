using System.Collections.Generic;

namespace CarModel.Models
{
    public class CarType
    {
        public int Id { get; set; }
        public string Enginge { get; set; }
        public List<Car> Cars;
    }
}