using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        /// <summary>
        /// 观察者模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Secretary secretary = new Secretary();

            StockObserver observer1 = new StockObserver("lok", secretary);
            StockObserver observer2 = new StockObserver("Bi", secretary);

            Console.ReadKey();

        }

        ///继续学习一下订阅-发布模型
    }
}
