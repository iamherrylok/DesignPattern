using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPattern
{
    class Program
    {

        /// <summary>
        /// 编写一个手机通讯录的备忘录模式
        /// 三个角色 Originator--发起人  Memonto--备忘录  Caretaker--管理者
        /// 
        /// 注意创建备忘录时，假如数据为引用类型，需要使用深拷贝来复制多一份，而不是光光创建多一个引用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Originator originator = new Originator();

            originator.Add(new Person("lok", "12234523543"));
            originator.Add(new Person("bibi", "31432515324"));
            originator.Add(new Person("herry", "124543643165"));

            Caretaker caretaker = new Caretaker();
            caretaker.Memonto = originator.CreateMemonto();

            originator.Remove(0);
            originator.show();

            Console.WriteLine() ;

            originator.SetMemonto(caretaker.Memonto);
            originator.show();


            Console.ReadKey();



        }



    }
}
