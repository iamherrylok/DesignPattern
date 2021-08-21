using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    interface  HandSetSoft
    {
        void Run();
    }

    class HandSetGame : HandSetSoft
    {
        public void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }

    class HandSetAddressList : HandSetSoft
    {
        public void Run()
        {
            Console.WriteLine("运行手机通讯录");
        }
    }
}
