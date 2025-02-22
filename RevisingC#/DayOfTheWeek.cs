using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    internal class DayOfTheWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine( DayOfftheWeek());
        }

        public static string DayOfftheWeek()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            var datetime = new DateTime(year, month, day);
            return datetime.DayOfWeek.ToString();

        }
    }
}
