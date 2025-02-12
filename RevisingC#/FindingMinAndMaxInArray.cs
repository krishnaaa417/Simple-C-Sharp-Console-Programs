using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class FindingMinAndMaxInArray
    {
        static void Main(string[] args)
        {
            Min();
            Max();
        }

        public static void Min()
        {
            int[] nums = { 11, 22, 23, 43, 5, 63, 73, 8, 29,02 };
            int min = nums[0];

            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine("nini.."+min);

        }

        public static void Max()
        {
            int[] nums = { 1, 2, 93, 4, 565, 6, 7, 28, 9, 0 };
            int max = nums[0];

            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("maximum.."+max);
        }
    }
}
