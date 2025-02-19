using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class TernaryOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            //if (age < 18)
            //{
            //    Console.WriteLine("Your are minor");
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("Major");
            //}
            //else if (age > 45 && age < 90)
            //{
            //    Console.WriteLine("senior citizen");
            //}

            string status = age == 18 ? "Major" : "minor";
            Console.WriteLine(status);
        }
    }
}
