using DecoratorPattern.Abstract;
using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class HorizontalScrollbarWindow : WindowDecorator
    {
        public HorizontalScrollbarWindow(IWindow decoratedWindow) 
            : base(decoratedWindow)
        {
        }
        private string DrawHorizontalScrollbar(string draw)
        {
            return draw + " //";
        }
        public override string Draw()
        {
            string draw = base.Draw();
            string horizontalDraw = DrawHorizontalScrollbar(draw);
            return horizontalDraw;
        }
        public override string GetDescription()
        {
            return _decoratedWindow.GetDescription() + ", Added horizontal scrollbars";
        }
    }
}
