using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            IsPalindrome();
        }

        static void IsPalindrome()
        {
            Console.WriteLine("please enter a number");
            int palidrome = Convert.ToInt32(Console.ReadLine());
            int compare = palidrome;

            int number = 0;

            while (palidrome > 0)
            {
                int temp = palidrome % 10;
                number = number * 10 + temp;
                palidrome /= 10;
            }

            if (compare == number)
            {
                Console.WriteLine("It's a Palindrome..");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }


        }
    }


}
