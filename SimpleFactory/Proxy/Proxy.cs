using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy : IProxyMethod
    {
        Pursuit _pursuit = null;

        public Proxy(SchoolGirl girl)
        {
            _pursuit = new Pursuit(girl);
        }

        public void GiveChocolate()
        {
            _pursuit.GiveChocolate();
        }

        public void GiveDolls()
        {
            _pursuit.GiveDolls();
        }

        public void GiveFlower()
        {
            _pursuit.GiveFlower();
        }
    }
}
