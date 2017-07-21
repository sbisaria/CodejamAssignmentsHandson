using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(args[0]);
            double width = Convert.ToDouble(args[1]);
            double area = length * width;
            double perimeter = 2 * (length+width);
            Console.WriteLine("Area of rectangle is: \t" + area);
            Console.WriteLine("Perimeter of rectangle is: \t" + perimeter);
            Console.ReadLine();
        }
    }
}
