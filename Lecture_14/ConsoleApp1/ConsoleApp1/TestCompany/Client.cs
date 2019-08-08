using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TestCompany
{
    sealed class Client : Human
    {
        private static int _cientCount = 0;
        private int _clientId;
        public Client(string name) : base(name) {
            _cientCount++;
            _clientId = _cientCount + 1;
        }

        public override void PrintInfo() {
            Console.WriteLine($"Client name: {_name}");
        }

        public int ClientId()
        {
            return _clientId;
        }

    }
}
