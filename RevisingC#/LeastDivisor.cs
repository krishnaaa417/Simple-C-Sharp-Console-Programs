using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class LeastDivisor
    {
        static void Main(string[] args)
        {
            LeastDivisors();
        }

        static void LeastDivisors()
        {
            Console.WriteLine("please enter your number");
            
            int number = Convert.ToInt32(Console.ReadLine());
            int divisor = 2;
            while (divisor < number)
            {
                if (number % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    break;
                }
               
                divisor++;
            }
            
        }
    }
}
