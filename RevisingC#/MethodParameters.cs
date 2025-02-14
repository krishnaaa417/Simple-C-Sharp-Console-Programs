using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    // how to pass the values to the parameter..
    internal class MethodParameters
    {
        static void Main(string[] args)
        {
            int a = 10;
            

            Console.WriteLine("Before passing");
            Parameters p = new Parameters();
            Console.WriteLine("After passing");
            Console.WriteLine(p.Add( a));
            Console.WriteLine("call by ref before passing"+a);
            Console.WriteLine(p.Callbyref(ref  a));
            Console.WriteLine("call by out before passing.");
            Console.WriteLine(p.Callbyout(out int a1));
        }
    }

    public class Parameters
    {
        // this call by value..
        public int Add(int a)
        {
            a = 1000;
            return a;
        }

        // below method about call-by-ref

        public int Callbyref(ref int a)
        {
            a = 10000;
            return a;
        }

        public int Callbyout(out int a)
        {
            a = 1;
            return a;
        }
    }
}
