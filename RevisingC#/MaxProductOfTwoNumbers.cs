using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class MaxProductOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = { 500, 4, 3, 6, 7, 0 };
            Console.WriteLine(ProductOfTwo(arr));
        }

        static int ProductOfTwo(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array length does not contain two numbers");
            }
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int num in arr)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if(num  > max2)
                {
                    max2 -= num;
                }
            }
            return max1 * max2;
        }
    }
}
