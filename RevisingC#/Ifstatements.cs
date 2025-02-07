using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Ifstatements
    {
        static void Main(string[] args)
        {
            Ifcondition();
        }

        public static void Ifcondition()
        {
            Console.WriteLine("please enter a number");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Congrats, you are eligible for Voting..");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for voting.");
            }
        }

        public static void Addition()
        {
          

            
        }
    }
}
