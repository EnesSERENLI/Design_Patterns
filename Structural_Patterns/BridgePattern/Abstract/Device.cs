using BridgePattern.Concrete;
using BridgePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstract
{
    public abstract class Device
    {
        protected IVideoPlayer _videoPlayer;
        protected ISoundPlayer _soundPlayer;

        public abstract void PlayMovie(Video video);
        
    }
}
