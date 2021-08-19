using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface StateBase
    {
        void WriteProgram(Work work);
    }

    class ForenoonState : StateBase
    {
        public void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"当前时间：{work.Hour} 点 上午工作，精神百倍！");
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }

    class NoonState : StateBase
    {
        public void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"当前时间：{work.Hour} 点 饿了 午饭：犯困，午休！");
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }

    class AfternoonState : StateBase
    {
        public void WriteProgram(Work work)
        {
            if (work.Hour<17)
            {
                Console.WriteLine($"当前时间：{work.Hour} 点 下午状态还不错，继续努力！");
            }
        }
    }

    

}
