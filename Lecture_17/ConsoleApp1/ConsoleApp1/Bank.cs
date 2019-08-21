using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public delegate void EventHandler(string s);
    class Bank
    {
        
        public event EventHandler Handle;
        public void AddHandler(EventHandler eventHandler)
        {
            Handle += eventHandler;
        }

        public void MakeTransaction(string s)
        {
            if (Handle != null)
            {
                Handle(s);
            }
        }
    }
}
