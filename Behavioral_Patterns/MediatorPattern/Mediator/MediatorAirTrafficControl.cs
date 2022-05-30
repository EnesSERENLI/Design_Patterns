using MediatorPattern.Abstract;
using MediatorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Mediator
{
    public class MediatorAirTrafficControl : IAirTrafficControl
    {
        private readonly List<AirPlaneBase> _airplanes;
        public MediatorAirTrafficControl()
        {
            _airplanes = new List<AirPlaneBase>();
        }

        public void AddAirPlanes(params AirPlaneBase[] airPlanes) //airlines will add
        {
            _airplanes.AddRange(airPlanes);
        }

        public void SendMessage(string message, AirPlaneBase messageProcedurAirPlane) //will forward the message to other airline companies except the company that sent the message.
        {
            List<AirPlaneBase> otherAirplanes = _airplanes.Where(airPlanes => airPlanes != messageProcedurAirPlane).ToList();

            otherAirplanes.ForEach(x => x.Notify(message));
        }
    }
}
