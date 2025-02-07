using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class BasicConsoleMethods
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Apple");
            //Console.Write("Two..");
            //Console.WriteLine("Three");
            //Console.ReadLine();
            //Console.Read();
            //Console.ReadKey();
            //Console.BackgroundColor = ConsoleColor.Red;
            // Console.Beep();

            // read the two integers and add them fuckinglyy

            Console.WriteLine("please enter the firstnumber..");
            int fuck1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the secondnumber.");
            int fuck2 = Convert.ToInt32(Console.ReadLine());
            int hardfuck = fuck1 + fuck2;
            Console.WriteLine("Oh my god it's a hard fuck {0}, and {1} then it's {2}",fuck1,fuck2,hardfuck);
        }
    }
}
