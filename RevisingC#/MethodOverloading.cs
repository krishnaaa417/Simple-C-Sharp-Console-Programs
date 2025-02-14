using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class MethodOverloading
    {
        static void Main(string[] args)
        {
            Overload o = new Overload();
            o.Add();
            o.Add(3, 3);
            o.Add("Venkata", "Krishna");
        }
    }

    public class Overload
    {
        public void Add()
        {
            Console.WriteLine("Without-Any-Parameters.");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers."+(a+b));
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("join the strings.."+(a+b));
        }
    }
}
