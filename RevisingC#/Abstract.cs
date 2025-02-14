using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    public class Abstract
    {
        static void Main(string[] args)
        {
            Vehicle varchar = new Car();
            varchar.StartEngine();
            varchar.DisplayInfo();

            Vehicle varchar2 = new Bike();
            varchar2.StartEngine();
            varchar2.DisplayInfo();

            Car varchar3 = new Car();
            Console.WriteLine(varchar3);
        }

    }

    public abstract class Vehicle
    {
        // this is abstract class and abstraction using abstract classes .

        protected Vehicle()
        {
            Console.WriteLine("Date:"+DateTime.Now);
        }
        public abstract void StartEngine(); // abstract method..

        public void DisplayInfo()
        {
            Console.WriteLine("This is a vehicle..");
        }

    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine has started.");
        }
    }

    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Sorry Bike does not have Engine..but Bike-ENgine Works..");
        }
    }
}
