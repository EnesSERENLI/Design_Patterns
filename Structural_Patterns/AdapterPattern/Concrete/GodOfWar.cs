using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class GodOfWar:PsGame // GodOfWar PlayStation'a özel oyun.
    {
        private string _gameName;
        public GodOfWar()
        {
            _gameName = "God Of War";
        }

        public string PlayWithPlaystation()
        {
            Console.WriteLine("The game started to be played");
            return _gameName;
        }
    }
}
