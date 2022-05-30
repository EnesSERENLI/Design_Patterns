using ChainOfResponsibility.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChainOfResponsibilityPattern");
            Console.WriteLine("");

            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            //"Nut","MeatBall", "Banana", "Cup of coffee"

            dog.SetNext(squirrel).SetNext(monkey);

            Client.ClientCode(dog, "MeatBall");//The dog eats the meat and does not send it to the next.

            Console.WriteLine("----------------");

            Client.ClientCode(dog, "Nut");//The dog does not eat the nut and sends it to the squirrel.The squirrel eats the nut and does not send it to the monkey.

            Console.WriteLine("----------------");

            Client.ClientCode(dog, "Banana"); //Dog and squirrel don't eat bananas. They send it to the monkey. The monkey eats the banana.
            Console.WriteLine("----------------");

            Client.ClientCode(dog, "Cup of coffee"); //Dog, squirrel and monkey don't drink coffee. Nobody touches the coffee.
            Console.Read();
        }
    }
}
