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
        public Starter(IListOfTransportOutput listOfTransportOutput, IListOfTransportSort listOfTransportSort, IListOfTransportFilter listOfTransportFilter)
        {
        _listOfTransport = new ListOfTransport();
        _listOfTransportOutput = listOfTransportOutput;
        _listOfTransportSort = listOfTransportSort;
        _listOfTransportFilter = listOfTransportFilter;
        }

        public void Run()
        {
            _listOfTransportOutput.Output(_listOfTransport.TransportList);
            _listOfTransportSort.Sort(_listOfTransport.TransportList);
            Console.WriteLine("Sorted transport list:");
            _listOfTransportOutput.Output(_listOfTransport.TransportList);
            Console.WriteLine("Filtered array:");
            _listOfTransportOutput.Output(_listOfTransportFilter.Filter(_listOfTransport.TransportList));
        }
    }
}
