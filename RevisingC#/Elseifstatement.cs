using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Elseifstatement
    {
        static void Main(string[] args)
        {
            Elseconditions();
        }

        public static void Elseconditions()
        {
            Console.WriteLine("please enter your age..");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 0 && age <= 5)
            {
                Console.WriteLine("Baby");
            }
            else if (age > 5 && age <= 12)
            {
                Console.WriteLine("Kid");
            }
            else if (age > 12 && age <= 18)
            {
                Console.WriteLine("Teenage");
            }
            else if (age > 18 && age <= 25)
            {
                Console.WriteLine("adult");
            }
            else if (age > 25 && age <= 48)
            {
                Console.WriteLine("Man");
            }
            else
            {
                Console.WriteLine("Old Man");
            }
        }
    }
}
