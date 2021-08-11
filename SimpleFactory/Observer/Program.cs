using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        public static bool Tag = false;
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

            if (!Tag)
            {
                Thread thread = new Thread(DeleteFile);
                thread.Start();
                thread.IsBackground = true;  //后台线程
            }
        }

        public static void DeleteThread()
        {
            while (true)
            {
                while (DateTime.Now.ToString("HHmmss") == "100000")
                {
                    DeleteFile();
                }
            }
           
        }


        public static void DeleteFile()
        {

        }


        ///继续学习一下订阅-发布模型
    }
}
