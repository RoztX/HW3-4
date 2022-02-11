using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal abstract class Transport
    {
        public string? Type { get; set; }
        public int NumberOfPassengers { get; set; }
        public int Speed { get; set; }
        public FuelType Fuel { get; set; }

        public abstract void MySpecifications();
    }
}
