using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Concrete
{
    public class Speaker : ISoundPlayer
    {
        public void PlaySound(string sound) => Console.WriteLine("Hoparlörden ses geliyor. Gelen ses: " + sound);
    }
}
