using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Observer : IObserver
    {
        public string ObserverName { get; set; }
        public bool Notification { get; set; }
        public Observer(string name)
        {
            ObserverName = name;
        }
        public void Update()
        {
            Console.WriteLine($"Hi! {ObserverName} a new product has arrived at the store. How about you take a look ?");
        }
    }
}
