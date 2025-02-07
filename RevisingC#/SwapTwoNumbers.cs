using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            //SwappingNumber();
            Swappingthenumberwithoutusingthirdvariable();
        }

        static void SwappingNumber()
        {
            Console.WriteLine("please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping the values.."+first+",,"+second);

            int third = second;
            second = first;
            first = third;

            Console.WriteLine("After swapping the values.."+first+",,"+second);
        }

        static void Swappingthenumberwithoutusingthirdvariable()
        {
            Console.WriteLine("please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping the values.." + first + ",," + second);

            first = first + second;
            second = first - second;
            first = first - second;

            Console.WriteLine("After swapping the values.." + first + ",," + second);
        }
    }
}
