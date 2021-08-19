using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPattern
{
    class Memonto
    {
        public List<Person> People
        {
            get;
        }

        public Memonto(List<Person> people)
        {
            People = people;
        }

    }
}
