using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class PrintHelper
    {
        public static void Print (string message, params object[] args )
        {
            Console.WriteLine(message);
            Console.Write(":");
            Console.WriteLine();
            PrintElems(args);
        }

        private static void PrintElems(params object[] args)
        {
            foreach (var item in args)
            {
                Console.Write($"{item}, ");
            }
        }

        public static void PrintTable(params object[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine($"{item.GetType()} {item}");
            }
        }
    }
}
