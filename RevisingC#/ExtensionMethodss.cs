using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class ExtensionMethodss
    {
        static void Main(string[] args)
        {
            string message = "krishna";
            string reversedMessage = message.ReverseString();
            Console.WriteLine("reverse"+","+reversedMessage);
        }
    }

    public static class StringExtensions
    {
        public static string ReverseString(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
