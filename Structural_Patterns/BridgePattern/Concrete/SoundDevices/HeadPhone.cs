using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Concrete.VideoDevices
{
    public class HeadPhone : ISoundPlayer
    {
        public void PlaySound(string sound) => Console.WriteLine("Kulaklıktan ses geliyor. Gelen ses: " + sound);
    }
}