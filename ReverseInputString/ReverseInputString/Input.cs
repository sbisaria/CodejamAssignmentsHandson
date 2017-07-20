using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInputString
{
    public class Input
    {
        public string GetInputString()
        {
            Console.WriteLine("Enter a string:\n");
            string inputString = Console.ReadLine();  
            return inputString;
        }
    }
}
