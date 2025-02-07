using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class MaxnumberofEqualVariables
    {
        static void Main(string[] args)
        {
            MaxNumOfEqualVariables();
        }

        public static void MaxNumOfEqualVariables()
        {
            Console.WriteLine("please enter the numbers");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            if ((a == b || a == c))
            {
                count++;
            }
            else if (a == b && a == c && b ==c)
            {
                count++;
            }
            else
            {
                Console.WriteLine(count);
            }

            

            Console.WriteLine("Max number of equal variables."+count);
        }
    }
}
