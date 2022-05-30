using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Interface
{
    public interface IHandler
    {
        object Handle(object request);

        IHandler SetNext(IHandler handler);
    }
}
