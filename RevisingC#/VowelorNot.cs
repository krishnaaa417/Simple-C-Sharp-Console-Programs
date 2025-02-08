using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class VowelorNot
    {
        static void Main(string[] args)
        {
            VowelOrNot();
        }

        static void VowelOrNot()
        {
            Console.WriteLine("please enter your charcter");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            c = char.ToLower(c);

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("It is vowel.." + c);
            }
            else
            {

                Console.WriteLine("It's a consonant.."+c);
            }
        }
    }
}
