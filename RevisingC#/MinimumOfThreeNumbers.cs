using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class MinimumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Minimumofthreenumbers();
        }

        static void Minimumofthreenumbers()
        {
            Console.WriteLine("please enter the three numbers");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            if (first < second && first < third)
            {
                Console.WriteLine("minimum number .." + first);
            }
            else if (second < first && second < third)
            {
                Console.WriteLine("minimum number.. " + second);
            }
            else if (third < first && third < second)
            {
                Console.WriteLine("minimum .."+third);
            }
            else
            {
                Console.WriteLine("all are equal"+first);
            }
        }
    }
}
