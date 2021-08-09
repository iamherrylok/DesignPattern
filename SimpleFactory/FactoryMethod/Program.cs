using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 100;
            double num2 = 300;

            IFactory factory = new AddFactory();
            ICal operation = factory.GetInstance();
            operation.Calculate(num1,num2,out double result);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
