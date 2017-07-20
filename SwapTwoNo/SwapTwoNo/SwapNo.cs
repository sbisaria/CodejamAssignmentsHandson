using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNo
{
    public class SwapNo
    {
        public void Swap(int firstNumber, int secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            InputOutput inputOutput = new InputOutput();
            inputOutput.Display(firstNumber,secondNumber);
        }
    }
}
