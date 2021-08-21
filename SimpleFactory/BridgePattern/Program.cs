using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        /// <summary>
        /// 桥接模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            HandSetBrand ab;
            ab = new HandSetBrandM();
            ab.SetHandSetBrand(new HandSetGame());
            ab.SetHandSetBrand(new HandSetAddressList());
            ab.Run();

            HandSetBrand ad;
            ad = new HandSetBrandN();
            ad.SetHandSetBrand(new HandSetAddressList());
            ad.SetHandSetBrand(new HandSetGame());
            ad.Run();

            Console.ReadKey();

        }





        ///桥接模式提供一个原则：
        ///合成-聚合复用原则
        ///优先使用对象的合成/聚合将有助于你对保持每个类呗封装，并被集中在单个任务上，这样类和类继承层次会保持较小规模，并且不太可能增长为不可控制的庞然大物。
        ///简单来说就是：在使用继承前，思考一下能不能使用对象的合成或聚合模式来降低耦合性
        
    }
}
