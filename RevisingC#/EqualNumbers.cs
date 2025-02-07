using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class EqualNumbers
    {
        static void Main(string[] args)
        {
            Equalnumbers();
        }

        static void Equalnumbers()
        {
            Console.WriteLine("please enter three numbers.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && a == c)
            {
                Console.WriteLine("3");
            }

            else if (a == b || a == c)
            {
                Console.WriteLine("2");
            }
            else
            {

                Console.WriteLine("0");
            }
        }

    }
}
