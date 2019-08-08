using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    struct Structure : IPrintData
    {
        public string name;
        public int age;
        public List<int> listOfInts;

       
        public void printData()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
            Console.WriteLine("listOfInts: ");
            foreach (int item in listOfInts)
            {
                Console.Write($" ,{item}");
            }
        }
    }
}
