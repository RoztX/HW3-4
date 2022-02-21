using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public class FlyingTransport : Transport
    {
        public int FlightAltitude { get; set; }

        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed:{Speed}km/h Fuel type: {Fuel} Flight Altitude: {FlightAltitude}");
        }
    }
}
