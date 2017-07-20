using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNo
{
    public class InputOutput
    {
        public void GetTwoNumbers()
        {
            SwapNo swapNo = new SwapNo();
            int firstNumber;
            int secondNumber;
            while (true)
            {
                Console.WriteLine("Enter the first no:");
                bool isValidFirstInput = int.TryParse(Console.ReadLine(), out firstNumber);
                Console.WriteLine("Enter the second no:");
                bool isValidSecondInput = int.TryParse(Console.ReadLine(), out secondNumber);
                if (isValidFirstInput && isValidSecondInput)
                {
                    swapNo.Swap(firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
       public void Display(int firstNoAAftreSwap, int secondNoAfterSwapped)
        {
            Console.WriteLine("First Number after Swappping: \t{0}", firstNoAAftreSwap);
            Console.WriteLine("SecondNUmber after Swapping:\t{0}", secondNoAfterSwapped);
        }
    }
}
