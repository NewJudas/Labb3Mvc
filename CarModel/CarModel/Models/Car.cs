using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string RegNr { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarTypeId { get; set; }
        public virtual CarType CarType { get; set; }
    }
}
