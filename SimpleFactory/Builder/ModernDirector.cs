using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ModernDirector : HomeBuilder
    {
        public override void Door()
        {
            home.parts.Add("现代门");
        }

        public override void Floor()
        {
            home.parts.Add("现代地板");
        }

        public override Home GetHome()
        {
            return home;
        }

        public override void Roof()
        {
            home.parts.Add("现代屋顶");
        }

        public override void Window()
        {
            home.parts.Add("现代窗户");
        }
    }
}
