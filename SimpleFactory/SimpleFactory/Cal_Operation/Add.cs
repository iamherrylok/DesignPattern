using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Add : Operation
    {
        public override void Calculate(double param1, double param2, ref double result)
        {
            result = param1 + param2;
        }
    }
}
