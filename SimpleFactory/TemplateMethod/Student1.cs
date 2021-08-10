using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Student1:TestPaper
    {
        public override string SetAnswer1()
        {
            return "A";
        }

        public override string SetAnswer2()
        {
            return "B";
        }

        public override string SetAnswer3()
        {
            return "C";
        }
    }
}
