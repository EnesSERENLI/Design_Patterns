using MediatorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstract
{
    public abstract class AirPlaneBase
    {
        protected readonly IAirTrafficControl _airTrafficControl;
        public AirPlaneBase(IAirTrafficControl airTrafficControl)
        {
            _airTrafficControl = airTrafficControl;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}
