using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Fact();
        }

        static void Fact()
        {

            Console.WriteLine("Please enter the number");
            int fact = Convert.ToInt32(Console.ReadLine());
            int result = 1;
           

            for (int i = fact; i > 0; i--)
            {
                result = result * i;
            }

            Console.WriteLine("Total-value.."+result );

        }
    }
}
