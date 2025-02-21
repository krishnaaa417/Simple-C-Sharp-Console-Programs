using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class CountTheDigitsOfNumber
    {
        static void Main(string[] args)
        {
            Digits();
        }

        static void Digits()
        {
            int n = 91214;
            int temp = 0;
             while (n > 0)
            {
                int result = n % 10;
               temp++;
                n = n / 10;
            }
            Console.WriteLine(temp);
        }
    }
}
