using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class ListOfTransportFilter :IListOfTransportFilter
    {
        public Transport[] Filter(Transport[] transports)
        {

            Console.WriteLine("Choose the type of filtering:\n1.By type of fuel\n2.By speed\n3.By the number of passengers");
            int type = 3.GetFromConsole();
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
            return null;
        }

        private Transport[] FilterByFuelType(Transport[] transports)
        {
            Console.WriteLine("Choose the type of fuel:\n1.Petrol\n2.Diesel\n3.AviationFuel\n4.SpaceFuel\n5.Gas");
            int type = 5.GetFromConsole();
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
            int minSpeed = 10000.GetFromConsole();
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
            int minNumber = 810.GetFromConsole();
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
