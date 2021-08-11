using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        /// <summary>
        /// 建造者模式主要作用是将建造流程和实现分开
        /// 通过抽象类来固定流程
        /// 实现者来继承抽象类后重写所需流程
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ModernDirector modernDirector = new ModernDirector();
            modernDirector.Roof();
            modernDirector.Window();
            modernDirector.Floor();
            modernDirector.Door();
            modernDirector.GetHome().Show();


            Console.ReadKey();
        }
    }
}
