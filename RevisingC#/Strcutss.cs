using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Strcutss
    {
        static void Main(string[] args)
        {
            S1 s;//= new S1();
            s.x = 1001;
            s.y = 2002;
            Console.WriteLine(s.x);
            Console.WriteLine(s.y);
        }
    }

    public struct S1
    {
        public int x; public int y;
        public S1(int x1 ,int y1)
        {
            x = x1;
            y = y1;
        }
    }
}
