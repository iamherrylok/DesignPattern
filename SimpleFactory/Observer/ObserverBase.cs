using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class ObserverBase
    {
        public string _name;
        public SecretaryBase _sub;

        public ObserverBase(string name, SecretaryBase secretary)
        {
            _name = name;
            _sub = secretary;
        }

        public void Update()
        {
            Console.WriteLine($"{_sub.SecretaryAction} {_name}  关闭股票行情，继续工作");
        }
    }
}
