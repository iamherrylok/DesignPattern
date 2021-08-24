using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Command
    {
        protected Barbecuer _barbecuer;
        public Command(Barbecuer barbecuer)
        {
            _barbecuer = barbecuer;
        }

        public abstract void ExcuteCommand();
    }
}
