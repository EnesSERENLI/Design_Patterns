using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class SimpleWindow : IWindow //En temel, basit penceremizi abstract class'tan yada bu şekilde interface den oluşturuyoruz..
    {
        public string Draw()
        {
            return "//";
        }

        public string GetDescription() => "Simple Window";
    }
}
