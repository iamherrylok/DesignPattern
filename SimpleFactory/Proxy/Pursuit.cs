using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Pursuit : IProxyMethod
    {
        SchoolGirl _girl = null;

        public Pursuit(SchoolGirl girl)
        {
            _girl = girl;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{_girl.Name} 送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{_girl.Name} 送你钱");
        }

        public void GiveFlower()
        {
            Console.WriteLine($"{_girl.Name} 送你花");
        }
    }
}
