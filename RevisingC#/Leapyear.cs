using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Leapyear
    {
        static void Main(string[] args)
        {
            Leapyears();
        }

        public static void Leapyears()
        {
            Console.WriteLine("please enter a  year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Your year is leap year");
            }
            else
            {
                Console.WriteLine("Sorry your year is not a Leap year");
            }

        }
    }
}
