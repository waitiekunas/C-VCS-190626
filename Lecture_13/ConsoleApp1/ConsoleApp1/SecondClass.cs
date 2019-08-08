using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SecondClass
    {
        private string name = "Povilas";

        private string SetName{
            set{ name = value; }
        }

        public string GetSetName
        {
            get { return name; }
            set { SetName = value; }
        }

        public string GetName()
        {
            return name;
        }

        private void Rename(string newName)
        {
            name = newName;
        }

    }
}
