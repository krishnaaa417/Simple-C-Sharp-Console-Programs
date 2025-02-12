using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class DoWhiles
    {
        static void Main(string[] args)
        {
            Do();
        }

        static void Do()
        {
            string choice;
            do
            {
                Console.WriteLine("Welcome to dotnet tricks");
                Console.Write("Do you want it print again (y/n)");
                choice = Console.ReadLine();
            }
            while (choice == "y");
            Console.WriteLine("Exit");
            Console.ReadKey();


        }
    }
}
