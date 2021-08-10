using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class TestPaper
    {
        public void Question1()
        {
            Console.WriteLine("问题1：question");
            Console.WriteLine($"答案： {SetAnswer1()}");
        }

        public void Question2()
        {
            Console.WriteLine("问题2：question");
            Console.WriteLine($"答案： {SetAnswer2()}");
        }
        public void Question3()
        {
            Console.WriteLine("问题3：question");
            Console.WriteLine($"答案： {SetAnswer3()}");
        }


        public virtual string SetAnswer1()
        {
            return "";
        }

        public virtual string SetAnswer2()
        {
            return "";
        }
        public virtual string SetAnswer3()
        {
            return "";
        }


    }
}
