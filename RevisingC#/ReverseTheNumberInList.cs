using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class ReverseTheNumberInList
    {
        static void Main(string[] args)
        {
            List<int> reverseNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            reverseNumber.Reverse();
           
            foreach (int i in reverseNumber)
            {
                Console.Write(i + ",");
            }


        }
    }
}
