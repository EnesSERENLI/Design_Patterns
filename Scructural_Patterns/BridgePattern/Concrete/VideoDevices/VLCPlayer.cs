using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Concrete.VideoDevices
{
    public class VLCPlayer : IVideoPlayer
    {
        public string PlayVideo(Video video)
        {
            Console.WriteLine("VLC Player " + video + " videosunu oynatıyor..");
            return video.VideoSound;
        }
    }
}
