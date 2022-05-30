using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Subject : ISubject
    {
        private List<Observer> observerList = new List<Observer>();

        private int _inventory;
        public int Inventory
        {
            get => _inventory;
            set
            {
                if (value > _inventory)
                {
                    Notify();
                }
                _inventory = value;
            }
        }
        public void Notify()
        {
            foreach (Observer observer in observerList)
            {
                if (observer.Notification == true)
                {
                    observer.Update();
                }           
            }
        }

        public void Subscribe(Observer observer)
        {
            observerList.Add(observer);
        }

        public void UnSubscribe(Observer observer)
        {
            observerList.Remove(observer);
        }

    }
}
