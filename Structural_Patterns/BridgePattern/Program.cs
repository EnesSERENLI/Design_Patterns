using BridgePattern.Concrete;
using BridgePattern.Concrete.VideoDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video movie = new Video("Brave Heart","Freedommmmmmmm!!!"); //Bir adet video oluşturduk

            Computer computer = new Computer(new SplashPro(),new Speaker()); //Bu videoyu istersek splashpro ile hoparlörden izleyebiliriz.
            Computer computer2 = new Computer(new VLCPlayer(),new HeadPhone());//İstersekte VLC Player ile kulaklıktan izleyebiliriz. veya yine hoparlör e bağlayabiliriz.

            computer.PlayMovie(movie);

            computer2.PlayMovie(movie);
            Console.Read();
        }
    }
}
