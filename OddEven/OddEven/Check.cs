
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Check
    {
        public void CheckOddEven(double number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered no is even");
            }
            else
            {
                Console.WriteLine("Entered no is odd");
            }
        }
    }
}
