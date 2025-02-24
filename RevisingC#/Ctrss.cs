using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Ctrss
    {
        static void Main(string[] args)
        {
            //Constructor c = new Constructor("krishna",27);
            //c.Hello();
            //TypesOfConstructorss t = new TypesOfConstructorss();
            //TypesOfConstructorss t1 = new TypesOfConstructorss(14,6);
            //StaticConstructor.Print();
            CopyConstructor copy = new CopyConstructor();
            CopyConstructor copy2 = new CopyConstructor("Copyy");
            CopyConstructor copy3 = new CopyConstructor(copy2);
            Console.WriteLine(copy3.Name);
            
        }
    }

    public class Constructor
    {
        public string name;
        public int age;
        public Constructor(string name,int age)
        {
            this.name = name;
              this.  age = age;
        }

        public void Hello()
        {
            Console.WriteLine(name+","+age);
        }
    }

    public class TypesOfConstructorss
    {
        // default constructor
        //Parameterized constructor
        //copy constructor
        //chain constrcutor
        //static constrcutor
        //private constrcutor

        public TypesOfConstructorss()
        {
            Console.WriteLine("Default-Constructor");
        }

        public TypesOfConstructorss(int a,int b)
        {
            Console.WriteLine("Parameterized-Constructor.."+(a+b));
        }
    }

    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("I'm Static Constructor..");
        }

        public static void Print()
        {
            Console.WriteLine("I'm static method Print..");
        }
    }

    public class CopyConstructor
    {
        public CopyConstructor()
        {
            Console.WriteLine("I'm copy constructor.");


        }

        public string Name;
        public CopyConstructor(string name)
        {
            this.Name = name;
        }

        //copy constrcutor

        public CopyConstructor(CopyConstructor copy)
        {
            Name = copy.Name;
        }
    }
}
