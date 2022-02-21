using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public class SortList : ISort
    {
        public void Sort(Transport[] list)
        {
            Console.WriteLine("Select a sorting option: \n1.By Speed Highest to Lowest \n2.By Speed Lowest to Highest \n3.By Number of Passengers Highest to Lowest \n4.By Number of Passengers Lowest to Largest");
            int numberOfOptions = 4;
            int option = numberOfOptions.GetFromConsole();
            switch (option)
            {
                case 1:
                    SortBySpeedDescending(list);
                    break;
                case 2:
                    SortBySpeedAscending(list);
                    break;
                case 3:
                    SortByNumberOfPassengersDescending(list);
                    break;
                case 4:
                    SortByNumberOfPassengersAscending(list);
                    break;
            }
        }

        private void SortByNumberOfPassengersAscending(Transport[] list)
        {
            Transport container;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i].NumberOfPassengers < list[j].NumberOfPassengers)
                    {
                        container = list[i];
                        list[i] = list[j];
                        list[j] = container;
                    }
                }
            }
        }

        private void SortByNumberOfPassengersDescending(Transport[] list)
        {
            Transport container;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i].NumberOfPassengers > list[j].NumberOfPassengers)
                    {
                        container = list[i];
                        list[i] = list[j];
                        list[j] = container;
                    }
                }
            }
        }

        private void SortBySpeedAscending(Transport[] list)
        {
            Transport container;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i].Speed < list[j].Speed)
                    {
                        container = list[i];
                        list[i] = list[j];
                        list[j] = container;
                    }
                }
            }
        }

        private void SortBySpeedDescending(Transport[] list)
        {
            Transport container;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i].Speed > list[j].Speed)
                    {
                        container = list[i];
                        list[i] = list[j];
                        list[j] = container;
                    }
                }
            }
        }
    }
}
