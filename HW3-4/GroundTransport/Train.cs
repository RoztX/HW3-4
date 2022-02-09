using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Train : GroundTransport
    {
        public Train(int numberOfPassengers, int speed, int numberOfWheels)
        {
            Type = "Train";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = FuelType.Diesel;
            NumberOfWheels = numberOfWheels;
        }

    }
}
