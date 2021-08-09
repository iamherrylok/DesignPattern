using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SubCal : ICal
    {
        public void Calculate(double num1, double num2, out double result)
        {
            result = num1 - num2;
        }
    }
}
