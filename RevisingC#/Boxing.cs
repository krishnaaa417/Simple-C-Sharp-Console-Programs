using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Boxing
    {
        static void Main(string[] args)
        {
           Explicitboxing();
            Implicitboxing();
        }

        public static void Explicitboxing()
        {
            object obj = 10;
            int i = (int)obj;
            Console.WriteLine(i);
        }

        public static void Implicitboxing()
        {
            int a = 100;
            object o = a;
            Console.WriteLine(o);
        }
    }
}
