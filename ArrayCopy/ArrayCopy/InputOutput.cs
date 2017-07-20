using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    public class InputOutput
    {
        public int GetArraySize()
        {
            bool isValidSize = false;
            int arraySize;
            do
            {
                Console.WriteLine("Enter the array size");

                isValidSize = int.TryParse(Console.ReadLine(), out arraySize);
                if (isValidSize == false)
                    Console.WriteLine("Invalid value");
            } while (isValidSize == false);
            return arraySize;
        }
    }
}
