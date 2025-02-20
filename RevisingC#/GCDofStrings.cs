using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class GCDofStrings
    {
        static void Main(string[] args)
        {

            //ABCABC //ABC
            //OUTPUT ABC
            Console.WriteLine(GcdOfStrings("ABABAB", "ABAB")); ;
        }

        static string GcdOfStrings(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str2))
            {
                return (str1);
            }

            else if(str1.Length < str2.Length)
            {
                return GcdOfStrings(str2, str1);
            }
            else if (!str1.StartsWith(str2))
            {
                return "";
            }
            
            else
            {
                return GcdOfStrings(str1.Substring(str2.Length), str2);
            }
        }
    }
}
