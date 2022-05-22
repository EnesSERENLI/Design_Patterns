using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class PsPcAdapter:PcGame //PlayStation oyununu pc'de oynamak için bir adapter oluşturduğumuzu düşünelim. Bu yüzden Pc oyunu oynamamızı sağlayan interface'i buraya kalıtım olarak verdik ve içerisinde ki metodu implement ettik.
    {
        private PsGame _psGame; //ps oyunlarını oynanmızı sağlayan interface'i burada private olarak tanımlıyoruzki implement ettiğimiz metotta bu field ile 
        public PsPcAdapter(PsGame psGame) //constructor'a bir playstation oyunu veriyoruz
        {
            _psGame = psGame;
        }

        public string PlayWithComputer()
        {
            return _psGame.PlayWithPlaystation();
        }
    }
}
