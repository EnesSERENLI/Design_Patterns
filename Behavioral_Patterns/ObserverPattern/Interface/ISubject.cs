using ObserverPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interface
{
    public interface ISubject
    {
        void Subscribe(Observer observer);
        void UnSubscribe(Observer observer);
        void Notify();
    }
}
