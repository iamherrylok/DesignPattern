using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class SecretaryBase
    {
        public List<ObserverBase> _stockObservers = new List<ObserverBase>();
        public string SecretaryAction { get; set; }

        public abstract void AddObserver(ObserverBase stockObserver);

        public abstract void RemoveObserver(ObserverBase stockObserver);

        public abstract void Notify();

    }
}
