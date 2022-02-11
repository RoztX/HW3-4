using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class JetSki : MaritimeTransport
    {
        public JetSki(int speed, FuelType fuel, int crew, bool haveBanana)
        {
            Type = "JetSki";
            NumberOfPassengers = haveBanana ? 12 : 2;
            Speed = speed;
            Fuel = fuel;
            Crew = crew;
        }

        public bool HaveBanana { get; set; }
    }
}
