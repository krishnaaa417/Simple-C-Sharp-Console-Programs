using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
   public delegate void Dele(int x, int y);
    internal class Delegates
    {
        static void Main(string[] args)
        {
            Dele d = new Dele(Add);
            d = d + Mul;
            d(20, 30);
            //d1(20,30);
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
}
