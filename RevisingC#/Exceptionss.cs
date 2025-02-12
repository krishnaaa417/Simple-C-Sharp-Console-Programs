using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Exceptionss
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
           

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int number1 = Convert.ToInt32(Console.ReadLine());
                int result = number / number1;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
