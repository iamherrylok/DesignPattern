using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 抽象主类 可以用抽象类、也可以用接口 
    /// </summary>
    public abstract class Operation
    {
        public abstract void Calculate(double param1, double param2, ref double result);


    }

    
}
