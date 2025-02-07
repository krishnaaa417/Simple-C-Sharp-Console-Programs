using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    /*
     * 1
     * 12
     * 123
     * 1234
     */
    internal class WhileLoops
    {
        static void Main(string[] args)
        {
            //Pattern();
            WhileLoop();
        }

        //static void Pattern()
        //{
        //    //int k = 1;
            
        //        for (int i = 1; i <= 4; i++)
        //        {
        //            for (int j = 1; j <= i; j++)
        //            {
        //                Console.Write(j);
        //            }
        //            Console.WriteLine();
        //        }
        //       // k++;
        //    }

        //static void WhileLoop()
        //{
        //    int i = 1;
        //    while (i < 5)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j);
        //        }
        //        Console.WriteLine();

        //        i++;
        //    }
        //}

        //static void WhileLoop()
        //{
        //    int i = 1;

        //    while (i < 5)
        //    {
        //        int j = 1;

        //        while (j <= i)
        //        {
        //            Console.Write(j);
        //            j++;
        //        }
        //        Console.WriteLine();
        //        i++;
        //    }
        //}

        static void WhileLoop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i * 2);
                i += 1;
            }
        }

        }
}
