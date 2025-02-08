using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class IfandElse
    {
        static void Main(string[] args)
        {
            EvenOrOdd();
        }

        static void EvenOrOdd()
        {
            Console.WriteLine("please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even-number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
