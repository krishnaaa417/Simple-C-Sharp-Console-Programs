using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class SwitchStatements
    {
        static void Main(string[] args)
        {
            Switch_Statements();
        }

        static void Switch_Statements()
        {
            Console.WriteLine("please enter your marks");
            int marks = Convert.ToInt32(Console.ReadLine());

            
            switch (marks/10)
            {
                case 10:
                case 9: Console.WriteLine("A+"+"Outstanding");
                    break;
                case 8: Console.WriteLine("A"+"Excellend");
                    break;
                case 7: Console.WriteLine("B+"+"Very good");
                    break;
                    case 6: Console.WriteLine("B" + "Good");
                    break;
                    case 5: Console.WriteLine("C" + "Average");
                    break;
                case 4: Console.WriteLine("D"+"Pass");
                    break;
                    default: Console.WriteLine("Fail");
                    break;

            }
        }
    }
}
