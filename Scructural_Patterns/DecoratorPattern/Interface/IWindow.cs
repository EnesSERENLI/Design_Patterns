using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Interface
{
    public interface IWindow //Öncelikle pencere için bir interface yada abstrack class oluşturabiliriz..
    {
        string Draw();

        string GetDescription();
    }
}
