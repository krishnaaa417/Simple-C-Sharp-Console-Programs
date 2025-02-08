using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class LargestAmontThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Large(a, b, c);
            Console.WriteLine("largest number.." + d);
        }

        static int Large(int a,int b,int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
               return b;
            }
            else
                return c;
            

            
        }
    }
}
