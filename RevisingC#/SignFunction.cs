using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class SignFunction
    {
        static void Main(string[] args)
        {
            SignFunc();
        }

        static void SignFunc()
        {
            Console.WriteLine("please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("1");
            }
            else if (number < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("0");
            }
            
        }
    }
}
