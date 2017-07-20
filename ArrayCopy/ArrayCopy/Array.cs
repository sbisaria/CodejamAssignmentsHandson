using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    public class Array
    {
        string[] elements;
        public Array(int size)
        {
            elements = new string[size];
        }

        public void TakeUserInput()
        {
            Console.WriteLine("Enter the {0} elements of array", elements.Length);
            for (int index = 0; index <elements.Length; index++)
            {
                elements[index] = Console.ReadLine();
            }
        }

        public void CopyTo(Array otherArray)
        {
            for (int index = 0; index < elements.Length; index++)
            {
                otherArray.elements[index] = elements[index];
            }
        }

        public void DisplayElements()
        {
            Console.WriteLine("The array contains following elements");
            for (int index = 0; index < elements.Length; index++)
            {
                Console.WriteLine(elements[index]);
            }
        }
    }
}
