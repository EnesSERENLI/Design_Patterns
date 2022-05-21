using AdapterPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pc pc = new Pc();
            Pubg pubg = new Pubg();
            CsGo csGo = new CsGo();

            pc.PlayGame(pubg);//bilgisayar oyunu oynanabiliyor.
            pc.PlayGame(csGo);//bilgisayar oyunu oynanabiliyor.

            GodOfWar godOfWar = new GodOfWar();

            //pc.PlayGame(godOfWar); Bunu yapamayız çünkü GodOfWar PlayStation oyunu.. 

            PsPcAdapter adapter = new PsPcAdapter(godOfWar); //Ancak adapter yardımıyla Gof Of War'ı bilgisayar oyunlarına benzettiğimizi düşünelim ve artık bilgisayardada oynayabilir hale geldi..
            pc.PlayGame(adapter); 

            Console.ReadLine();
        }
    }
}
