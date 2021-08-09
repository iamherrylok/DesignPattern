using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    class Person
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"装扮 {Name}");
        }
    }
}
