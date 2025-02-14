using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Encapsulatio e = new Encapsulatio();
            e.EmpExperience = 10;
            Console.WriteLine(e.EmpExperience);
            
        }
    }

    public class Encapsulatio
    {
        private int empExperience;

        public int EmpExperience
        {
            get {  return empExperience; }
            set { empExperience = value; }
        }

    }
}
