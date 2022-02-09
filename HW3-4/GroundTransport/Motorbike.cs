﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Motorbike : GroundTransport
    {
        public string Brand { get; set; }
        public Motorbike(int numberOfPassengers, int speed, int numberOfWheels, string brand)
        {
            Type = "Motorbike";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = FuelType.Petrol;
            NumberOfWheels = numberOfWheels;
            Brand = brand;
        }

        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed: {Speed}km/h Fuel type: {Fuel} Number of wheels: {NumberOfWheels} Brand: {Brand}");

        }
    }
}
