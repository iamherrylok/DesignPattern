using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class Realty
    {
        public string Name { get; set; }

        public Realty(string name)
        {
            Name = name;
        }

        public void Sell()
        {
            Console.WriteLine($"{Name}卖出");
        }

        public void Buy()
        {
            Console.WriteLine($"{Name}买入");
        }
    }
}
