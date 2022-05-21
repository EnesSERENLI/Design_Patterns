using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class Pc //Elimizde bir adet bilgisayar olduğunu düşünelim ve bununla oyun oynayacağız.
    {
        public void PlayGame(PcGame game)
        {
            string gameName = game.PlayWithComputer();
            Console.WriteLine("GameName: "+gameName);
        }
    }
}
