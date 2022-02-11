using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public static class MyExtensions
    {
        public static int GetFromConsole(this int number)
        {
            int contain;
            while (true)
            {
                contain = Convert.ToInt32(Console.ReadLine());
                if (contain > 0 && contain <= number)
                {
                    break;
                }

                Console.WriteLine("Invalid value entered");
            }

            return contain;
        }
    }
}