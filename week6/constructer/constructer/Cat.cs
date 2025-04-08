using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructer
{
    internal class Cat
    {
        public string Name;
        public string Color;

        public static int Ncat = 0;

        public Cat()
        {
            Name = "";
            Color = "";
            Ncat++;
        }

        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
            Ncat++;
        }

        ~Cat()
        {
            Ncat--;
        }
    }
}
