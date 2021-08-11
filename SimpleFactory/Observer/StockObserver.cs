using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class StockObserver:ObserverBase
    {
        private string _name;

        private SecretaryBase _secretary;

        public StockObserver(string name, SecretaryBase secretary):base(name,secretary)
        {
            
        }

        public void Update()
        {
            Console.WriteLine($"{_secretary.SecretaryAction} {_name}  关闭股票行情，继续工作");
        }
    }
}
