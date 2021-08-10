using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume myResume = new Resume("Lok");
            myResume.SetPersonalInfo("男", "26");
            myResume.SetWorkExperience("2000-2001", "BM");
            myResume.Display();

            Resume resume2 = (Resume)myResume.Clone();
            resume2.SetWorkExperience("2001-2002", "Tencent");
            resume2.Display();

            ///当原型模式中带有引用类型属性，就不能简单地使用浅拷贝
            DeepResume deepResume = new DeepResume("Bibi");
            deepResume.SetPersonalInfo("男", "26");
            deepResume.SetWorkExperience("2000-2001", "BM");

            DeepResume deepResume2 = (DeepResume)deepResume.Clone();
            deepResume2.SetWorkExperience("2001-2002", "Tencent");

            DeepResume deepResume3 = (DeepResume)deepResume.Clone();
            deepResume3.SetWorkExperience("2003-2004", "Alibaba");

            deepResume.Display();
            deepResume2.Display();
            deepResume3.Display();

            //使用深拷贝来实现带有引用类型属性的原型模式
            FinalDeepResume finalDeepResume = new FinalDeepResume("Herry");
            finalDeepResume.SetPersonalInfo("男", "26");
            finalDeepResume.SetWorkExperience("2000-2001", "BM");

            FinalDeepResume finalDeepResume2 = (FinalDeepResume)finalDeepResume.Clone();
            finalDeepResume2.SetWorkExperience("2001-2002", "Tencent");

            FinalDeepResume finalDeepResume3 = (FinalDeepResume)finalDeepResume.Clone();
            finalDeepResume3.SetWorkExperience("2003-2004", "Alibaba");

            finalDeepResume.Display();
            finalDeepResume2.Display();
            finalDeepResume3.Display();

            Console.ReadKey();



        }
    }
}
