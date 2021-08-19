using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();

            work.Hour = 12;
            work.WriteProgram();



            Console.ReadKey();
        }
    }

    class Test
    {
        public  static int Hour = 0;
        public static bool WorkFinished = false;

        public static void WriteProgram()
        {
            if (Hour<12)
            {
                Console.WriteLine($"当前时间：{Hour} 点 上午工作，精神百倍！");
            }
            else if(Hour<13)
            {
                Console.WriteLine($"当前时间：{Hour} 点 饿了 午饭：犯困，午休！");
            }
            else if (Hour<17)
            {
                Console.WriteLine($"当前时间：{Hour} 点 下午状态还不错，继续努力！");
            }
            else
            {
                if (WorkFinished)
                {
                    Console.WriteLine($"当前时间：{Hour} 点 下班回家了！");
                }
                else
                {
                    if (Hour<21)
                    {
                        Console.WriteLine($"当前时间：{Hour} 点 加班，疲惫至极");
                    }
                    else
                    {
                        Console.WriteLine($"当前时间：{Hour} 点 不行了，睡着了");
                    }
                }
            }
        }
    }
}
