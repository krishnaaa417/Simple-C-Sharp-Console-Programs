using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class GCDinArray
    {
        static void Main(string[] args)
        {
            InArray();
        }

        static void InArray()
        {
            int[] nums = { 2, 5, 6, 9, 10 };
            int min = nums.Min();
            int max = nums.Max();

           

            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
