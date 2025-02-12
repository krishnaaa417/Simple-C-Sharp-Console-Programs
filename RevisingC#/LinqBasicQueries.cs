using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class LinqBasicQueries
    {
        static void Main(string[] args)
        {
            //  Linqs();
            LinqString();
        }

        public static void Linqs()
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var result = list.Where(x => x% 2 == 0).ToList();

           // var result1 = result.OrderByDescending(x => x).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void LinqString()
        {
            List<string> list = new List<string>()
            {
                "nallapothula","venkata","krishn","undavalli","navya","chowdhry","bitch-shron","pilla-linzaa shabana","adar-lanza-madhu_mounika","nenu-erripuku ni"
            };

            // var result = list.Where(x => x.Contains("a")).ToList();
            //var result = list.Where(x => x.StartsWith("a")).ToList();
            var result = list.Select(x=>x.Length).ToList();
            foreach (var item in result)
            {
                Console.Write(item+",");
            }
        }


    }
}
