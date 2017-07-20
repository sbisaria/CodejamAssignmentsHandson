using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterDemo
{
    public class InputOutput
    {
        public void Input()
        {
            Calculate calculate = new Calculate();
            double firstNo,secondNo,thirdNo,forthNo, one,two,three;
            Console.WriteLine("Enter the first No:");
            bool isValidfirstNo = double.TryParse(Console.ReadLine(),out firstNo);

            Console.WriteLine("Enter the second No:");
            bool isValidsecondNo = double.TryParse(Console.ReadLine(), out secondNo);

            Console.WriteLine("Enter the third No:");
            bool isValidthirdNo = double.TryParse(Console.ReadLine(), out thirdNo);

            Console.WriteLine("Enter the forth No:");
            bool isValidforthNo = double.TryParse(Console.ReadLine(), out forthNo);

            if (isValidfirstNo && isValidsecondNo && isValidthirdNo && isValidforthNo)
            {
                calculate.Addition(firstNo, secondNo, thirdNo, forthNo,out one);
                calculate.Substraction(firstNo, secondNo, thirdNo, forthNo,out two);
                calculate.Multiplication(firstNo, secondNo, thirdNo, forthNo,out three);
                Console.WriteLine("Addition result: \t" + one + "\nSubstraction result:\t" + two + "\nMultiplication result:\t" + three);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Input");                
            }
        }
    }
}
