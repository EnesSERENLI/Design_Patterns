using MediatorPattern.Abstract;
using MediatorPattern.Concrete;
using MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediatorAirTrafficControl mediatorAirTrafficControl = new MediatorAirTrafficControl();

            AirPlaneBase airBusAirPlane = new AirBusAirPlane(mediatorAirTrafficControl); 
            AirPlaneBase boeingAirPlane = new BoeingAirPlane(mediatorAirTrafficControl); 

            mediatorAirTrafficControl.AddAirPlanes(airBusAirPlane);
            mediatorAirTrafficControl.AddAirPlanes(boeingAirPlane);

            airBusAirPlane.Send("Can we land right now ?");
            Console.WriteLine("----------");

            boeingAirPlane.Send("No! We're landing, wait ...");
            Console.WriteLine("----------");

            // Demonstrate landing ...
            Console.WriteLine("Boeing is landing ...");

            Thread.Sleep(TimeSpan.FromSeconds(3)); //waiting for 3 seconds..

            Console.WriteLine("----------");

            boeingAirPlane.Send("We landed.");
            Console.WriteLine("----------");

            airBusAirPlane.Send("OK, We're going to land ...");
            Console.WriteLine("----------");

            boeingAirPlane.Send("Good luck.");

            Console.ReadKey();
        }
    }
}
