using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class SafetyTypeCasting
    {
        static void Main(string[] args)
        {
            object ob = "100";
            if (ob is int number)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("casting failed ra sharon lanzaa");
            }
        }
    }
}
