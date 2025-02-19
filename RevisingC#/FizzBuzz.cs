using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            FizzBuzz a = new FizzBuzz();
            IList<string> result = a.FizzBuzzs(15);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public IList<string> FizzBuzzs(int n)
        {
            List<string> s = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    s.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    s.Add( "Fizz");
                }
                else if (i % 5 == 0)
                {
                    s.Add("Buzz");
                }
                else
                {
                    s.Add(i.ToString());
                }
            }
            return s;
        }
    }
}
