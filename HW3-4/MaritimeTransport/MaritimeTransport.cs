using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public class MaritimeTransport : Transport
    {
        public int Crew { get; set; }

        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed:{Speed}km/h Fuel type: {Fuel} Crew size {Crew} people");
        }
    }
}
