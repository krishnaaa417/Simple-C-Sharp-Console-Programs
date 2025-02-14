using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class BasicStringOperations
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //string k = Console.ReadLine();
            //string result = s + k;
            //Console.WriteLine(result);
            //Console.WriteLine("----------");
            //string replace = result.Replace("krishna", "venkata");
            //Console.WriteLine(replace);
            //Difference();
            Strings();
        }

        public static void Difference()
        {
            // basically string is immutable and it occupy different memory in process
            string str1 = "Interview";
            str1 = str1 + "Preparation";
            Console.WriteLine(str1);
        }

        public static void Strings()
        {
            //stringbuilder is immutable we can change the value once created,
            StringBuilder sb = new StringBuilder();
            sb.Append("Interview");
            sb.Append("Preparation");
            Console.WriteLine(sb);
        }

    }
}
