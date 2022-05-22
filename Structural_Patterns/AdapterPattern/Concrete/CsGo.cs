using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class CsGo : PcGame // CsGo bilgisayar oyunu
    {
        private string _gameName;
        public CsGo()
        {
            _gameName = "CsGo";
        }
        public string PlayWithComputer()
        {
            Console.WriteLine("The game started to be played");
            return _gameName;
        }
    }
}
