using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class DogHandler:AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request}.\n";
            }
            else
            {
                Console.WriteLine($"Dog: I won't eat the {request}.");   
                return base.Handle(request);
            }
        }
    }
}
