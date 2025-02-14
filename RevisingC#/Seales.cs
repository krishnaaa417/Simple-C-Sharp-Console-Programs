using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    // by using sealed class we can prevent a class from Inheried
    internal class Seales 
    {
        static void Main(string[] args)
        {
            Inheritance1 i = new Inheritance1();
            Console.WriteLine(i.Sum(2,2));
        }
    }

    public sealed class Inheritance1
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
