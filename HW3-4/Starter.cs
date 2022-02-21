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
        private readonly IOutput _output;
        private readonly ISort _sort;
        private readonly IFilter _filter;
        public Starter(IOutput output, ISort sort, IFilter filter)
        {
        _listOfTransport = new ListOfTransport();
        _output = output;
        _sort = sort;
        _filter = filter;
        }

        public void Run()
        {
            _output.Output(_listOfTransport.TransportList);
            _sort.Sort(_listOfTransport.TransportList);
            Console.WriteLine("Sorted transport list:");
            _output.Output(_listOfTransport.TransportList);
            Console.WriteLine("Filtered array:");
            _output.Output(_filter.Filter(_listOfTransport.TransportList));
        }
    }
}
