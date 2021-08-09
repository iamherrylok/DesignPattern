using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Add : IOperation
    {
        public void GetResult(string num1, string num2, out string result)
        {
            double num_1 = Convert.ToDouble(num1);
            double num_2 = Convert.ToDouble(num2);

            result = (num_1 + num_2).ToString();
        }
    }
}
