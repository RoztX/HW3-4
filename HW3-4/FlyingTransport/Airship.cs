﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public class Airship : FlyingTransport
    {
        public Airship(int numberOfPassengers, int speed, int flightAltiube, int volume)
        {
            Type = "Airship";
            NumberOfPassengers = numberOfPassengers;
            Speed = speed;
            Fuel = FuelType.AviationFuel;
            FlightAltitude = flightAltiube;
            Volume = volume;
        }

        public int Volume { get; set; }

        public override void MySpecifications()
        {
            Console.WriteLine($"Type: {Type} Maximum number of passengers: {NumberOfPassengers} people Speed:{Speed}km/h Fuel type: {Fuel} Flight Altitude: {FlightAltitude} Volume: {Volume}");
        }
    }
}
