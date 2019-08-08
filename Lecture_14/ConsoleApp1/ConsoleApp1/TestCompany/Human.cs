using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TestCompany
{
    class Human : LiveObject, IPrintMe
    {
        protected string _name;
        public override string GetRace()
        {
            return "Human";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(_name); ;
        }

        public Human(string name)
        {
            _name = name;
        }

        private Human() { }


    }
}
