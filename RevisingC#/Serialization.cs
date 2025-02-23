using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Serialization
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.Id = 1;
            emp.Name = "krishna";
            //convert object into json
            string json = JsonConvert.SerializeObject(emp);
            Console.WriteLine(json);
        }
    }

    public class Emp
    {
        public int Id;
        public string Name;
    }
}
