using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class PrimeNumberr
    {
        static void Main(string[] args)
        {
            
            
            Prime();
        }

        static void Prime()
        {
            int count = 0;
            Console.WriteLine("please enter your number");
            int prime = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    count++;
                }
            }
            if(count > 0) { Console.WriteLine("It's not a prime number"); }
            else { Console.WriteLine("It's a prime number"); }

        }
    }
}
