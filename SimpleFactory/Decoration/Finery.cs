using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    class Finery:Person
    {
        public Person _component;
        public void Decorate(Person person)
        {
            this._component = person;
        }
        public override void Show()
        {
            if (_component!=null)
            {
                _component.Show();
            }
        }
    }
}
