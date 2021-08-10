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

            Console.ReadKey();
        }
    }
}
