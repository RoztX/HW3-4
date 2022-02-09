using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class ListOfTransportOutput:IListOfTransportOutput
    {
        public void Output(Transport[] _transportList)
        {
            for (int i = 0; i < _transportList.Length; i++)
            {
                Console.Write($"{i+1}  ");
                _transportList[i].MySpecifications();
            }
        }
    }
}

