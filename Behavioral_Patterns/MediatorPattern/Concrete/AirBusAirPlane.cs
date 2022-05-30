using MediatorPattern.Abstract;
using MediatorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Concrete
{
    public class AirBusAirPlane : AirPlaneBase
    {
        public AirBusAirPlane(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("AirBusAirPlane gets message: " + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine("AirBusAirPlane sends message: " + message);
            _airTrafficControl.SendMessage(message, this);
        }
    }
}
