using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class PerfectSquarenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect-SquareNumber");
            int num = 16;
           for (int i = 1; i * i <= num; i++)
            {
                if(i * i == num)
                {
                    Console.WriteLine(i);
                }
            }

          
        }
    }
}
