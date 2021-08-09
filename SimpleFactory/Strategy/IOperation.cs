using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface IOperation
    {
        void GetResult(string num1,string num2,out string result);
    }
}
