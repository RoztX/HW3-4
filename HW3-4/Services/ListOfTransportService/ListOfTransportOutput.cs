using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    internal class ListOfTransportOutput : IListOfTransportOutput
    {
        public void Output(Transport[] transportList)
        {
            for (int i = 0; i < transportList.Length; i++)
            {
                Console.Write($"{i + 1}\t");
                transportList[i].MySpecifications();
            }
        }
    }
}