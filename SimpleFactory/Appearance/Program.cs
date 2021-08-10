using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class Program
    {
        /// <summary>
        /// 外观模式 
        /// 外观模式其实就是抽出一个主理人，将众多子项目的个别操作集合起来
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Appearance appearance = new Appearance();

            appearance.Sell();
            appearance.Buy();

            Console.ReadKey();
        }
    }
}
