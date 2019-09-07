using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Singleton
    {
        private static Singleton instance;
        private Singleton() {}
        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();

            }
            return instance;
        }
    }
}
