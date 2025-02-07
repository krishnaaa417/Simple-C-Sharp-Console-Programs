using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class SimpleWhileloop
    {
        static void Main(string[] args)
        {
            PrintOneToHundred();
            ReverseThenumber();
        }

        static void PrintOneToHundred()
        {
            int i = 1;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        static void ReverseThenumber()
        {
            int i = 100;
            while (i > 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }



       
    }
}
