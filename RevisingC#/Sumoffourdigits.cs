using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Sumoffourdigits
    {
        static void Main(string[] args)
        {
            SumoffourdigitsS();   
        }

        static void SumoffourdigitsS()
        {
            Console.WriteLine("please enter four digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = 0;

            while (number > 0)
            {
                temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
