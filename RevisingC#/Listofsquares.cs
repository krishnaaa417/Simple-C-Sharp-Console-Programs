using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Listofsquares
    {
        static void Main(string[] args)
        {
            squares();
        }

        static void squares()
        {
            Console.WriteLine("please enter the number");
            int square = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while ((i * i) < square)
            {
                Console.WriteLine(i*i);
                i++;
            }
            
        }
    }
}
