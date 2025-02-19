using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class Genrics
    {
        static void Main(string[] args)
        {
            bool equal = Calculators.AreEqual<int>(4, 4);
            bool strEqual = Calculators.AreEqual<string>("Interview", "Happy");
        }
    }

    internal class Calculators
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
