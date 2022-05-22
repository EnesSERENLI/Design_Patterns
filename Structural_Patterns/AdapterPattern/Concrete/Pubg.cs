using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class Pubg : PcGame //Pubg Bilgisayar oyunu
    {
        private string _gameName;
        public Pubg()
        {
            _gameName = "Pubg";
        }
        public string PlayWithComputer()
        {
            Console.WriteLine("The game started to be played");
            return _gameName;
        }
    }
}
