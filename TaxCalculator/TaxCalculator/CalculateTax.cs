using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    public class CalculateTax
    {
        public double GetTaxPercentage(double salary)
        {
            double taxPercent;
            if (salary < 10000)
            {
                taxPercent = 0.05;

            }
            else if (salary == 10000 || salary < 100000)
            {
                taxPercent = 0.08;
            }
            else
            {
                taxPercent = 0.085;
            }
            return taxPercent;
        }
        public double GetTax(double salary, double taxPercent)
        {
            double taxToBePaid = salary * taxPercent;
            return taxToBePaid;
        }
    }
}
