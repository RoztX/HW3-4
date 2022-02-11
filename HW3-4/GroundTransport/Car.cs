using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Car : GroundTransport
    {
        public Car(int numberOfPassengers, int speed, FuelType fuel, int numberOfWheels, string brand)
        {
            Type = "Car";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = fuel;
            NumberOfWheels = numberOfWheels;
            Brand = brand;
        }

        public string Brand { get; set; }

        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed: {Speed}km/h Fuel type: {Fuel} Number of wheels: {NumberOfWheels} Brand: {Brand}");
        }
    }
}
