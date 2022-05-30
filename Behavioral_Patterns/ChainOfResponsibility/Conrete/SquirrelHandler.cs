using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class SquirrelHandler:AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request}.\n";
            }
            else
            {
                Console.WriteLine($"Squirrel: I won't eat the {request}.");
                return base.Handle(request);
            }
        }
    }
}
