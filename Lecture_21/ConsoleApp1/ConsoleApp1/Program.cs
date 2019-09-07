using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy myProxy = new Proxy(new RealObject());
            myProxy.DoStuff();
        }
    }
}
