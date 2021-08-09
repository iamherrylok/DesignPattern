using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DivFactory : IFactory
    {
        public ICal GetInstance()
        {
            return new DivCal();
        }
    }
}
