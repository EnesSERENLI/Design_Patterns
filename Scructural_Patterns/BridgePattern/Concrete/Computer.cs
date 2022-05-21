using BridgePattern.Abstract;
using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Concrete
{
    public class Computer:Device
    {
        public Computer(IVideoPlayer videoPlayer,ISoundPlayer soundPlayer)
        {
            _videoPlayer = videoPlayer;
            _soundPlayer = soundPlayer;
        }
        public override void PlayMovie(Video video)
        {
            string sound = _videoPlayer.PlayVideo(video);
            _soundPlayer.PlaySound(sound);
        }
    }
}
