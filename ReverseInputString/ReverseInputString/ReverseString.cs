using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInputString
{
    public class ReverseString
    {
        public string Reverse(string originalString)
        {
            string reversedArray = "";
            for(int index = originalString.
                Length-1; index>=0;index--)
            {
                reversedArray += originalString[index];
            }
            return reversedArray;
        }
    }
}
