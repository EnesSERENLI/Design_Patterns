using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Concrete
{
    public class Video
    {
        public string VideoName { get; set; }
        public string VideoSound { get; set; }

        public Video(string videoName,string sound)
        {
            VideoName = videoName;
            VideoSound = sound;
        }

        public override string ToString() => VideoName;
    }
}
