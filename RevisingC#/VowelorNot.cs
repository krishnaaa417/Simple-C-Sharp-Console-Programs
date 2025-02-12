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
            //VowelOrNot();
            SWitchCOndition();

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

        static void SWitchCOndition()
        {
            Console.WriteLine("please enter a character");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("its vowel");
                    break;
                    case 'e':
                    Console.WriteLine("it's vowel");
                    break;
                    case 'i':
                    Console.WriteLine("It's vowel");
                    break;
                    case 'o':
                    Console.WriteLine("It's vowel");
                    break;
                case 'u':
                    Console.WriteLine("It's vowel");
                    break;
                default:
                    Console.WriteLine("It's constant");
                    break;
            }
        }
    }
}
