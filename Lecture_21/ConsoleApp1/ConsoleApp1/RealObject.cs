using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RealObject : IStuffDoer
    {
        public virtual void DoStuff()
        {
            Console.WriteLine("Real Object");
        }
    }
}
