using BridgePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Interface
{
    public interface IVideoPlayer
    {
        string PlayVideo(Video video);
    }
}
