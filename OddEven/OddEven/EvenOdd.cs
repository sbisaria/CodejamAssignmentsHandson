using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Check objectCheck = new Check();
            while (true)
            {
                Console.WriteLine("Enter a number");
                ulong number;
                bool check = ulong.TryParse(Console.ReadLine(), out number);
                if (check)
                {
                   objectCheck.CheckOddEven(number);
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please enter a valid one :)");
                }
            }
        }

    }
}
