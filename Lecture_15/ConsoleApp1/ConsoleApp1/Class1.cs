using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1 :IPrintData
    {
        public string name { get; set; }
        public int age { get; set; }
        public List<int> listOfInts { get; set; }

        public Class1()
        {
            name = "string";
            age = 1;
            listOfInts = new List<int>();
        }

        public void printData()
        {
            Console.WriteLine($"propString: {name}, propInt: {age}, propList: ");
            foreach (int item in listOfInts)
            {
                Console.Write($" {item}, ");
            }
        }
    }
}
