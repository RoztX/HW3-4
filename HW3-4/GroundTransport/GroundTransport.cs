using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class GroundTransport : Transport
    {
        public int NumberOfWheels { get; set; }
        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed: {Speed}km/h Fuel type: {Fuel} Number of wheels: {NumberOfWheels}");
        }
    }
}
