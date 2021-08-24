using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer barbecuer = new Barbecuer();
            Command command1 = new BakeMuttonCommand(barbecuer);
            Command command2 = new BakeChickenWingCommand(barbecuer);

            Waiter waiter = new Waiter();
            waiter.SetOrder(command1);
            waiter.SetOrder(command2);

            waiter.Notify();

            Console.ReadKey();

        }
    }
}
