using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNo, secondNo;
            Console.WriteLine("Enter 0 for power 1 for maximum and 2 for  mininmum :\t");
            string userChoice = Console.ReadLine();

            Console.WriteLine("Enter the first No:");
            bool isValidfirstNo = double.TryParse(Console.ReadLine(), out firstNo);

            Console.WriteLine("Enter the second No:");
            bool isValidsecondNo = double.TryParse(Console.ReadLine(), out secondNo);

            MathFunctios mathFunctions = new MathFunctios();

            switch (userChoice)
            {
                case "0":
                    double result = mathFunctions.Power(firstNo, secondNo);
                    Console.WriteLine("Value after applying power function is :\t" + result);
                    Console.ReadLine();
                    break;
                case "1":
                    double maxNo = mathFunctions.FindMaximum(firstNo, secondNo);
                    Console.WriteLine("Maximum value is :\t" + maxNo);
                    Console.ReadLine();
                    break;
                case "2":
                    double minNo = mathFunctions.FindMinimum(firstNo, secondNo);
                    Console.WriteLine("Mini,um value is :\t" + minNo);
                    Console.ReadLine();
                    break;


            }

        }
    }
}
