using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public class FilterList : IFilter
    {
        public Transport[] Filter(Transport[] transports)
        {
            Console.WriteLine("Choose the type of filtering:\n1.By type of fuel\n2.By speed\n3.By the number of passengers");
            int numberOfOptions = 3;
            int type = numberOfOptions.GetFromConsole();
            switch (type)
            {
                case 1:
                    {
                        return FilterByFuelType(transports);
                    }

                case 2:
                    {
                        return FilterBySpeed(transports);
                    }

                case 3:
                    {
                        return FilterByNumberOfPassengers(transports);
                    }
            }

            return FilterByFuelType(transports);
        }

        private Transport[] FilterByFuelType(Transport[] transports)
        {
            Console.WriteLine("Choose the type of fuel:\n1.Petrol\n2.Diesel\n3.AviationFuel\n4.SpaceFuel\n5.Gas");
            int numberOfOptions = 5;
            int type = numberOfOptions.GetFromConsole();
            var fuelType = (FuelType)type;
            int arraySize = 0;

            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].Fuel == fuelType)
                {
                    arraySize++;
                }
            }

            var array = new Transport[arraySize];
            arraySize = 0;
            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].Fuel == fuelType)
                {
                    array[arraySize++] = transports[i];
                }
            }

            return array;
        }

        private Transport[] FilterBySpeed(Transport[] transports)
        {
            Console.WriteLine("Enter your minimum speed:");
            int speedMax = 10000;
            int minSpeed = speedMax.GetFromConsole();
            int arraySize = 0;
            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].Speed >= minSpeed)
                {
                    arraySize++;
                }
            }

            var array = new Transport[arraySize];
            arraySize = 0;
            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].Speed >= minSpeed)
                {
                    array[arraySize++] = transports[i];
                }
            }

            return array;
        }

        private Transport[] FilterByNumberOfPassengers(Transport[] transports)
        {
            Console.WriteLine("Enter the minimum number of passengers:");
            int maxNumber = 810;
            int minNumber = maxNumber.GetFromConsole();
            int arraySize = 0;
            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].NumberOfPassengers >= minNumber)
                {
                    arraySize++;
                }
            }

            var array = new Transport[arraySize];
            arraySize = 0;
            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].NumberOfPassengers >= minNumber)
                {
                    array[arraySize++] = transports[i];
                }
            }

            return array;
        }
    }
}
