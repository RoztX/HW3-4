using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class Starter
    {
        private readonly ListOfTransport _listOfTransport;
        private readonly IListOfTransportOutput _listOfTransportOutput;
        private readonly IListOfTransportSort _listOfTransportSort;
        private readonly IListOfTransportFilter _listOfTransportFilter;

        public void Run()
        {
            _listOfTransportOutput.Output(_listOfTransport.transportList);
            _listOfTransportSort.Sort(_listOfTransport.transportList);
            Console.WriteLine("Sorted transport list:");
            _listOfTransportOutput.Output(_listOfTransport.transportList);
            Console.WriteLine("Filtered array:");
            _listOfTransportOutput.Output(_listOfTransportFilter.Filter(_listOfTransport.transportList));
            
        }

    }
}
