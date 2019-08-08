using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FirstClass
    {
        private static int age=1;
        public static int Age
        {
            get { return age; }
            set { SetAge = value; }
        }

        private static int SetAge
        {
            set { age = value; }
        }

        private static void SetAgeF(int agePar)
        {
            age = agePar;
        }

        public static int GetAge()
        {
            return age;
        }
    }
}
