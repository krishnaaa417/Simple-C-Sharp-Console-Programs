using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class TypesOfConstructors
    {
        static void Main(string[] args)
        {
            Typesofctrs t = new Typesofctrs(10,"Nallathula","Venkata",9121685852);
            t.Typess();
        }
    }

    public class Typesofctrs
    {
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Number { get; set; }

        public Typesofctrs(int Id,string FirstName, string LastName,long Number)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Number = Number;
        }

        public void Typess()
        {
            Console.Write(Id+","+FirstName+","+LastName+","+Number);
        }
    }
}
