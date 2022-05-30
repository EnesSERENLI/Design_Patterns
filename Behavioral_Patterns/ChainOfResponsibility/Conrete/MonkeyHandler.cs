using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class MonkeyHandler:AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request}.\n";
            }
            else
            {
                Console.WriteLine($"Monkey: I won't eat the {request}.");
                return base.Handle(request);
            }
        }
    }
}
