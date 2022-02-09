using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Airplane : FlyingTransport
    {
        public int WingSize { get; set; }
        public Airplane(int numberOfPassengers, int speed, int flightAltiube, int wingSize)
        {
            Type = "Airplane";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = FuelType.AviationFuel;
            FlightAltitude = flightAltiube;
            WingSize = wingSize;
        }

        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed:{Speed}km/h Fuel type: {Fuel} Flight Altitude: {FlightAltitude} Wingspan: {WingSize}");
        }
    }
}
