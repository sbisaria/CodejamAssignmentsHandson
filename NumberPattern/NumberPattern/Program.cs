using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCounter = 1, tempNo;
            while (rowCounter <= 5)
            {
                tempNo = 1;
                while (tempNo <= 5 - rowCounter)
                {
                    Console.Write(" ");
                    tempNo++;
                }
                tempNo = 1;
                while (tempNo < rowCounter)
                    Console.Write(tempNo++);
                while (tempNo > 0)
                    Console.Write(tempNo--);
                Console.WriteLine();
                rowCounter++;
            }
            Console.ReadKey();
        }
    }
}
