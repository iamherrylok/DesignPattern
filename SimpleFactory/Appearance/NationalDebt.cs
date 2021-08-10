using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class NationalDebt
    {
        public string Name { get; set; }

        public NationalDebt(string name)
        {
            Name = name;
        }

        public void Buy()
        {
            Console.WriteLine($"{Name}买入");
        }

        public void Sell()
        {
            Console.WriteLine($"{Name}卖出");
        }
    }
}
