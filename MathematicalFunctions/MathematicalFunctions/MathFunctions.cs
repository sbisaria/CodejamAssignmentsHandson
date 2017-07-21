using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFunction
{
    public class MathFunctios
    {
        public double Power(double firstNo, double secondNo)
        {
            double result = 1;
            for (double index = 1; index <= secondNo; index++)
            {
                result = result * firstNo;
            }
            return result;
        }

        public double FindMaximum(double firstNo, double secondNo)
        {
            if (firstNo > secondNo)
            {
                return firstNo;
            }
            else
            {
                return secondNo;
            }
        }
        public double FindMinimum(double firstNo, double secondNo)
        {
            if (firstNo < secondNo)
            {
                return firstNo;
            }
            else
            {
                return secondNo;
            }
        }
    }
}
