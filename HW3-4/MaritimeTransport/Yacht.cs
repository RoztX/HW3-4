using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Yacht : MaritimeTransport
    {
        public Yacht(int numberOfPassengers, int speed, FuelType fuel, int crew)
        {
            Type = "Yacht";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = fuel;
            Crew = crew;
        }
    }
}
