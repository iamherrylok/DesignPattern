using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class HomeBuilder
    {
        protected Home home = new Home();

        public abstract void Roof();
        public abstract void Floor();
        public abstract void Window();
        public abstract void Door();

        public abstract Home GetHome();
    }
}
