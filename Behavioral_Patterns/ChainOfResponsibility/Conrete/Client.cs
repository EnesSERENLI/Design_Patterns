using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler, string food)
        {
            Console.WriteLine($"Client: Who wants a {food}?");

            var result = handler.Handle(food);
            if (result != null)
            {
                Console.Write($"{result}");
            }
            else
            {
                Console.WriteLine($"{food} was left untouched.");
            }
        }
    }
}
