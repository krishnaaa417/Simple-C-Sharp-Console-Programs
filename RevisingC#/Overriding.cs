using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Overriding
    {
        static void Main(string[] args)
        {
            Method_Overriding1 method = new Method_Overriding1();
            method.Add(3, 3);
        }
    }

    public class Method_Overriding
    {
        public virtual void Add(int a,int b)
        {
            Console.WriteLine("Addition."+(a+b));
        }
    }

    public class Method_Overriding1 : Method_Overriding 
    {
        public override void Add(int a, int b)
        {
            Console.WriteLine("Mul.."+(a*b));
        }
    }
}
