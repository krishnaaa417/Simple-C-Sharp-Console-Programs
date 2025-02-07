using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Typecasting
    {
        static void Main(string[] args)
        {
            ImplicitTyping();
            ExplictTyping();
            Chars();
            Helpermethod();
        }

        public static void ImplicitTyping()
        {
            int a = 100;
            // short s = a;
            long l = a;
            Console.WriteLine(l);
        }

        public static void ExplictTyping()
        {
            int a = 200;
            short s = (short)a;
            Console.WriteLine(s);
        }

        public static void Chars()
        {
            char c = 'A';
            int d = (int)c;
            Console.WriteLine(d);
        }

        public static void Helpermethod()
        {
            string s = "233";
            int i = Convert.ToInt32(s);
            Console.WriteLine(i);
        }


    }
}
