using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterDemo
{
    public class Calculate
    {

        public void Addition(double first,double second, double third, double forth,out double additionResult)
        {
            additionResult = first + second + third + forth;
        }

        public void Substraction(double first, double second, double third, double forth,out double substractionResult)
        {
           substractionResult = first - second - third - forth;
        }

        public void Multiplication(double first, double second, double third, double forth,out double multiplicationResult)
        {
            multiplicationResult = first * second * third * forth;
        }
    }
}
