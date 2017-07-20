using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInputString
{
    class Program
    {
        static void Main(string[] args)
        {
            Input inputOutput = new Input();
            ReverseString reverseString = new ReverseString();
            Console.WriteLine("Reversed string is:\n"+reverseString.Reverse(inputOutput.GetInputString()));
            Console.ReadKey();

        }
    }
}
