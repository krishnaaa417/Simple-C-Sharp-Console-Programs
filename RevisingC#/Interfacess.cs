using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    public class Interfacess
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog("Chintuu");
            dog.speak();
            Console.WriteLine(dog.getName());

        }
    }

    public interface IAnimal
    {
        void speak();
        string getName();
    }

    public class Dog : IAnimal
    {
        private string name;
        public Dog(string name)
        {
            this.name = name;
        }

        public void speak()
        {
            Console.WriteLine("Boww");
        }

        public string getName()
        {
            return name;
        }
    }
}
