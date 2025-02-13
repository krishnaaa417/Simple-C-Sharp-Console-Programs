using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class StringMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a string");
            string name = Console.ReadLine();

            string[] arr = name.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("----------------");
            string s = "Nallapothula";
            string sub = s.Substring(3, 8);
            Console.WriteLine(sub);
        }
    }
}
