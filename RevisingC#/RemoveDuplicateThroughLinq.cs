using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class RemoveDuplicateThroughLinq
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 4, 34, 2, 2, 1, 6, 22, 102 };

            List<int> numbers = list.Distinct().ToList();

            Console.WriteLine("Unique numbers." + string.Join(",",numbers));
        }
    }
}
