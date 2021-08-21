using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class HandSetBrand
    {
        protected HandSetSoft _soft;

        public void SetHandSetBrand(HandSetSoft soft)
        {
            _soft = soft;
        }

        public abstract void Run();
    }


    class HandSetBrandM : HandSetBrand
    {
        public override void Run()
        {
            _soft.Run();
        }
    }


    class HandSetBrandN : HandSetBrand
    {
        public override void Run()
        {
            _soft.Run();
        }
    }
}
