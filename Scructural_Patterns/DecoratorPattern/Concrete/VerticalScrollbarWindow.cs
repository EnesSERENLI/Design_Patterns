using DecoratorPattern.Abstract;
using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class VerticalScrollbarWindow : WindowDecorator
    {
        public VerticalScrollbarWindow(IWindow decoratedWindow) 
            : base(decoratedWindow)
        {
        }

        private string DrawVerticalScrollbar(string draw)
        {
            return draw + " //";
        }

        public override string Draw()
        {
            string draw = base.Draw();
            string verticalDraw = DrawVerticalScrollbar(draw);
            return verticalDraw;
        }

        public override string GetDescription() => _decoratedWindow.GetDescription() + ", Added vertical scrollbars";
    }
}
