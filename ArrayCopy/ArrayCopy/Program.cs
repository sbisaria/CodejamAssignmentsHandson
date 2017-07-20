using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {

            InputOutput inputOutput = new InputOutput();
            int arraySize = inputOutput.GetArraySize();
            Array firstArray = new Array(arraySize);
            firstArray.TakeUserInput();

            Array secondArray = new Array(arraySize);
            firstArray.CopyTo(secondArray);
            secondArray.DisplayElements();
            Console.ReadLine();
        }
    }
}
