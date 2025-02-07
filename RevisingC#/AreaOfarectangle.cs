using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class AreaOfarectangle
    {
        static void Main(string[] args)
        {
            Rectangle();
        }

        static void Rectangle()
        {
            // area of rectangle = side * side;
            double side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of rectangle."+side*side);

           
        }
    }
}
