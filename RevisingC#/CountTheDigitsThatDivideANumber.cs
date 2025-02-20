using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class CountTheDigitsThatDivideANumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Counts(1248));
        }

        public static int Counts(int num)
        {

            int temp = num;
            int count = 0;
            int digit;
            while (temp > 0)
            {
                digit = temp % 10;
                temp = temp / 10;

                if (num % digit == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
