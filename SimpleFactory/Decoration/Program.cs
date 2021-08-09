using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "LOK";

            Tshirt tshirt = new Tshirt();
            Sneakers sneakers = new Sneakers();

            tshirt.Decorate(person);
            sneakers.Decorate(tshirt);

            sneakers.Show();

            Console.ReadKey();

        }
    }
}
