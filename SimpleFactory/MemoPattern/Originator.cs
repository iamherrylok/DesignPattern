using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPattern
{
    class Originator
    {
        public List<Person> people;

        public Originator()
        {
            people = new List<Person>();

        }

        public void Add(Person person)
        {
            people.Add(person);
        }

        public void Remove(int index)
        {
            if (index<0||index>people.Count)
            {
                return;
            }
            people.RemoveAt(index);
        }


        public Memonto CreateMemonto()
        {
            return new Memonto(new List<Person>(this.people));
        }

        public void SetMemonto(Memonto memonto)
        {
            this.people = memonto.People;
        }

        public void show()
        {
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name}  {item.PhoneNumber}");
            }
        }
    }
}
