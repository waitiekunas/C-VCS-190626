using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TestCompany
{
    class Pet : LiveObject, IPrintMe
    {
        public override string GetRace()
        {
            return "Pet";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Pet");
        }
    }
}
