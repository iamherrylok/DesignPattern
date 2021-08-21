using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            
        }

        public override void Display(int depth)
        {

        }

        public override void Remove(Component component)
        {
        }
    }
}
