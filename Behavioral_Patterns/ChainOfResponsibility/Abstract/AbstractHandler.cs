using ChainOfResponsibility.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Abstract
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandle;
        public virtual object Handle(object request) //Each animal will send the food it did not eat to the next. If there is no animal to send, the result will be empty.
        {
            if (_nextHandle != null)
            {
                return _nextHandle.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler) //The chain will be determined by this method.
        {
            _nextHandle = handler;
            return handler;
        }
    }
}
