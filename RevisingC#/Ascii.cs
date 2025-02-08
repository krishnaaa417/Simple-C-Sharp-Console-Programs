using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Ascii
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar; 
            Console.WriteLine(); 

            int asciiValue = (int)ch; 

            Console.WriteLine($"ASCII value of '{ch}' is: {asciiValue}");
        }
    }
}
