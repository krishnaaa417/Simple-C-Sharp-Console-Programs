using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            SimpleCalculator();
        }

        public static void SimpleCalculator()
        {
            Console.WriteLine("Welcome to the krishna Simple calculator");
            Console.WriteLine("Select any one option from the below dropdown");
            Console.WriteLine("a) Addition");
            Console.WriteLine("b) Subtraction");
            Console.WriteLine("c) Multiplication");
            Console.WriteLine("d) Division");

            Console.WriteLine("Please enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            char c = Convert.ToChar(Console.ReadLine());



            if (c == 'a')
            {
                Console.WriteLine("Addition.."+(num1+num2));
            }
            if (c == 'b')
            {
                Console.WriteLine("Subtraction.." + (num1 - num2));
            }
            if (c == 'd')
            {
                Console.WriteLine("Division.."+(num1/num2));
            }
            if (c == 'c')
            {
                Console.WriteLine("Multiplication.." + (num1 * num2));
            }
            else
            {
                Console.WriteLine("Sorry .. you entered wrong option");
            }
        }
    }
}
