using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Paramss
    {
        static void Main(string[] args)
        {
            int sum = Add(10, 20, 30, 40, 50);
            // Console.WriteLine(sum);
            //NamedParameters(a: 10, b: 20, c: 9292, d: 9.7);
            OptionalParameters("krishna");
        }

        public static int Add(params int[] nums)
        {
            int total = 0;
            foreach (int i in nums)
            {
                total += i;
            }
            return total;
        }

        public static void NamedParameters(int a, int b, float c, double d)
        {
            Console.WriteLine(a+","+b+","+c+","+d+",");
        }

        public static void OptionalParameters(string name, string greet = "hello")
        {
            Console.WriteLine(greet,name);
        }
    }
}
