using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class ListOfTransport
    {
        public Transport[] TransportList { get; set; } =
        {
             new Car(4, 400, FuelType.Petrol, 4, "Tesla"),
             new Car(5, 80, FuelType.Gas, 4, "Lada"),
             new Motorbike(2, 350, 2, "Kawasaki"),
             new Motorbike(3, 50, 3, "Dnieper"),
             new Train(810, 140, 120),
             new Airplane(8, 745, 4000, 10),
             new Airship(100, 135, 2000, 200000),
             new Rocket(10, 10000, 55760000),
             new JetSki(110, FuelType.Petrol, 1, false),
             new JetSki(100, FuelType.Petrol, 1, true),
             new Ship(1200, 80, FuelType.Diesel, 80),
             new Yacht(50, 50, FuelType.Petrol, 2)
        };
    }
}
