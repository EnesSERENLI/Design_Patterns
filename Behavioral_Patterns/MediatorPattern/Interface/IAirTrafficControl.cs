using MediatorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Interface
{
    public interface IAirTrafficControl
    {
        void AddAirPlanes(params AirPlaneBase[] airPlanes);
        void SendMessage(string message, AirPlaneBase messageProcedurAirPlane);
    }
}
