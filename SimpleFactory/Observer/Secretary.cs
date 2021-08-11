using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    delegate void EventHandler();
    class Secretary:SecretaryBase
    {
        public event EventHandler UpdateEvent;

        public override void AddObserver(ObserverBase stockObserver)
        {
            _stockObservers.Add(stockObserver);
        }

        public override void RemoveObserver(ObserverBase stockObserver)
        {
            _stockObservers.Remove(stockObserver);
        }

        public override void Notify()
        {
            foreach (var observer in _stockObservers)
            {
                observer.Update();
            }
        }

        public void UpdateEventAA()
        {
            UpdateEvent();
        }
    }
}
