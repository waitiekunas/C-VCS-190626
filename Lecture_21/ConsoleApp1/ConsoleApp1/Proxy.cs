using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Proxy : RealObject, IStuffDoer
    {
        private readonly RealObject realObject;
        public override void DoStuff()
        {
            Console.WriteLine("proxy");
            realObject.DoStuff();
        }

        public Proxy(RealObject real)
        {
            realObject = real;
        }
    }
}
