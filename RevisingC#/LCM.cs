using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class LCM
    {
        static void Main(string[] args)
        {
            Findlcm();
        }

        public static void Findlcm() // brute-force-approach
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

           int c = Math.Max(a,b);

            while (true)
            {
                if (c % a == 0 && c % b == 0)
                {
                    break;
                }
                c++;
            }
            Console.WriteLine(c);
        }
    }
}
