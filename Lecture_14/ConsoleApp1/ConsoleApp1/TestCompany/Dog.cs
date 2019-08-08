using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TestCompany
{
    class Dog : Pet
    {
        private string _name;
        public Dog(string name)
        {
            _name = name;
        }
        public override string GetRace()
        {
            return "Dog";
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Dogs name: {_name}");
        }
    }
}
