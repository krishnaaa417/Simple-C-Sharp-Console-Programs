using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class MinNumber
    {
        static void Main(string[] args)
        {
            Minimum();
        }

        public static void Minimum()
        {
            Console.WriteLine("please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int minimum;

            if (a < b)
            {
                minimum = a;
            }
            else
            {
                minimum = b;
            }
            Console.WriteLine("minimum number is.."+minimum);

        }
    }
}
