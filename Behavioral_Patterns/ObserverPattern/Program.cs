using ObserverPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer observer1 = new Observer("Enes"); //Enes and Onur will receive news because notifications are turned on.
            observer1.Notification = true;
            subject.Subscribe(observer1);

            subject.Inventory++;

            Observer observer2 = new Observer("Onur");
            observer2.Notification = true;
            subject.Subscribe(observer2);

            subject.Inventory++;

            Observer observer3 = new Observer("Bünyamin"); //Bünyamin will not be able to receive news because notifications are turned off.
            observer3.Notification = false;
            subject.Subscribe(observer3);

            subject.Inventory++;


            Console.Read();
            
        }
    }
}
