using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Inheritances : Inherit
    {
        public Inheritances() { Console.WriteLine("This is the Default-Constructor.."); }

        static void Main(string[] args)
        {
          Inheritances i = new Inheritances();
            i.I();
            i.I2();
        }
    }

    public class Inherit
    {
        public void I()
        {
            Console.WriteLine("This is the method of super-class..");
        }

        public void I2()
        {
            Console.WriteLine("This is the second method super-class2");
        }
    }
}


