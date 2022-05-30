using MediatorPattern.Abstract;
using MediatorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Concrete
{
    public class BoeingAirPlane : AirPlaneBase
    {
        public BoeingAirPlane(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("BoeingAirPlane gets message: " + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine("BoeingAirPlane sends message: " + message);
            _airTrafficControl.SendMessage(message,this);
        }
    }
}
