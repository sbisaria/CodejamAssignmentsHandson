using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManager
{
    class Program
    {
        static void Main(string[] args)
        {
            InputOutput input = new InputOutput();
            input.GetInput();
            input.Display();
            Console.ReadLine();
        }
    }
}
