using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class ExtensionMethods
    {
        static void Main(string[] args)
        {
            ExtensionMethods e = new ExtensionMethods();
            e.Add(10, 20);
            Console.WriteLine(e.Multiply(10, 10));


        }

        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        //written one extension method
        
    }

    internal static class Extension
    {
        public static int Multiply(this ExtensionMethods extensionMethods,int a, int b)
        {
            return a * b;
        }

    }
}
