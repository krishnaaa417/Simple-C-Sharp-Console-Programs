using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class PassbyValue
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("passbyvalue"+ x);
            Console.WriteLine("passbyvalue."+y);
           PassByRefernce(ref x, ref y);
            Console.WriteLine("pass-by-reference"+x);
            Console.WriteLine("pass-by-reference."+y);
        }

        static void PassByValue(int x,int y)
        {
            x = 100;
            y = 200;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
        }

        static void PassByRefernce(ref int x,ref int y)
        {
            x = 1000;
            y = 2000;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
        }
    }
}
