using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Rocket : FlyingTransport
    {

        public Rocket(int numberOfPassengers, int speed, int flightAltiube)
        {
            Type = "Rocket";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = FuelType.SpaceFuel;
            FlightAltitude = flightAltiube;
        }
    }
}
