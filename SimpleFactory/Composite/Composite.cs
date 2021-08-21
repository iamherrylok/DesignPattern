using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : Component
    {
        public List<Component> children = new List<Component>();

        public Composite(string name):base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Display(int depth)
        {
            
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
