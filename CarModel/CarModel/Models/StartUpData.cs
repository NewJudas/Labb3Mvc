using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel.Models
{
    public class StartUpData
    {
        public static void startUpData(IApplicationBuilder applicationBuilder)
        {
            CarContext context = applicationBuilder.ApplicationServices.GetRequiredService<CarContext>();

            if (!context.CarType.Any())
            {
                context.CarType.AddRange(CarTypes.Select(c => c.Value));
            }

            if (!context.Cars.Any())
            {
                context.AddRange
                (
                   new Car { CarBrand = "Volvo", RegNr = "abc124",CarModel="v70", CarType = CarTypes["v10"] },
                   new Car { CarBrand = "Saab", RegNr = "abc323", CarModel = "93", CarType = CarTypes["v6"] },
                   new Car { CarBrand = "Audi", RegNr = "abc223", CarModel = "A4", CarType = CarTypes["v8"] },
                   new Car { CarBrand = "Corvett", RegNr = "abc523", CarModel = "trams", CarType = CarTypes["v10"] },
                   new Car { CarBrand = "BMW", RegNr = "abd123", CarModel = "M7", CarType = CarTypes["v12"] },
                   new Car { CarBrand = "BMW", RegNr = "abd123", CarModel = "M3", CarType = CarTypes["v8"] }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, CarType> carType;
        public static Dictionary<string, CarType> CarTypes
        {
            get
            {
                if (carType == null)
                {
                    var carTypeList = new CarType[]
                    {
                        new CarType { Enginge = "v12" },
                        new CarType { Enginge = "v10" },
                        new CarType { Enginge = "v8" },
                        new CarType { Enginge = "v6" },
                    };

                    carType = new Dictionary<string, CarType>();

                    foreach (CarType size in carTypeList)
                    {
                        carType.Add(size.Enginge, size);
                    }
                }

                return carType;
            }
        }
    }
}
