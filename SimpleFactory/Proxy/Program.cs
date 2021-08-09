using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl girl = new SchoolGirl();
            girl.Name = "lok";

            Proxy proxy = new Proxy(girl);

            proxy.GiveFlower();
            proxy.GiveDolls();
            proxy.GiveChocolate();


            Console.ReadKey();
        }
    }
}
