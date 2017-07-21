using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the salary;\t");

            double salary = Convert.ToInt32(Console.ReadLine());
            double taxPercent;
            double taxToBePaid;
            CalculateTax calculateTax = new CalculateTax();
            taxPercent = calculateTax.GetTaxPercentage(salary);
            taxToBePaid = calculateTax.GetTax(salary, taxPercent);
            Console.WriteLine("\nTax to be paid is:\t" + taxToBePaid);
            Console.ReadLine();
        }
    }
}
