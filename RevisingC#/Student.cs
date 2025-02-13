using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Student
    {
        static void Main(string[] args)
        {
            Programs p = new Programs();
            p.StudentId = 101;
            p.Name = "Nallapothula";
            p.Address = "Bhagath-singh nagar.. Tadipatri..";
            p.ShowDetails();
        }

    }

    public class Programs
    {
        public int StudentId {  get; set; }

        public string Name { get; set; }

        public string Address {  get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Student Information..");
            Console.WriteLine(StudentId +"," + Name +","+Address);
        }
    }
}
