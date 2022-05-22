using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Abstract
{
    public abstract class WindowDecorator :IWindow //Tüm dekoratorler en temel pencerenin özelliklerini kullanacaklar. Bu yüzden interface'i buraya da implement ettik..
    {
        protected IWindow _decoratedWindow; //Dekore edeceğimiz pencereye artık en temel pencereyi değilde burada oluşturduğumuz Dekorator class'nı kalıtım olarak vereceğiz. Bu yüzden kalıtım verdiğimiz yerde pencerenin özelliklerine ulaşmak için de protected bir field tanımlıyoruz..

        public WindowDecorator(IWindow decoratedWindow)
        {
            _decoratedWindow = decoratedWindow;
        }

        public virtual string Draw()
        {
            return _decoratedWindow.Draw();
        }

        public virtual string GetDescription() => "Window Decorator";
    }
}
