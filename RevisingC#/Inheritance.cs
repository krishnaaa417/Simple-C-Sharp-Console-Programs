using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    public class Inheritance : Employee , Birds
    {
        static void Main(string[] args)
        {
            Inheritance i = new Inheritance();
            i.Experience = 3;
            i.CalculateSalary();
            i.Sounds();
          

            Birds b = new Inheritance();
            b.Fly();
        }
    }

    public class Employee : Birds
    {
        public int Experience { get; set; }

        
        private int Sum(int c, int d)
        {
            return c + d;
        }

        public void CalculateSalary()
        {
            int salary = Experience * 300;

            Console.WriteLine("salary: {0}",salary);
        }

        public void Sounds()
        {
            Console.WriteLine("The crow is sound like Kaav kaav..");
        }
    }

    interface Birds
    {
       
        void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        void Sounds();
    }
}
