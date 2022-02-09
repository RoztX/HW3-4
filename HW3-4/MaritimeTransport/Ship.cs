using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Ship : MaritimeTransport
    {
        public Ship(int numberOfPassengers, int speed, FuelType fuel, int crew)
        {
            Type = "Ship";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = fuel;
            Crew = crew;
        }
    }
}
