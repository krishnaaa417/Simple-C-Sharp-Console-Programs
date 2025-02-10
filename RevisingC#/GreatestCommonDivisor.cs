using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
           // Gcd();
            GCD_Bruteforceapproach();
        }

        static void Gcd()
        {
            Console.WriteLine("please provide the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please provide the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            while (b != 0)
            {
                int temp = b; //12 , 18 temp = 18
                b = a % b; // 18 = 6
                a = temp; //

            }
            Console.WriteLine(a);

        }

        static void GCD_Bruteforceapproach()
        {
            Console.WriteLine("please provide the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please provide the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int min = 0;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }

            // iterating the elements

            for (int i = min; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
