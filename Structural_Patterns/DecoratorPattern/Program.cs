using DecoratorPattern.Concrete;
using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWindow window1 = new SimpleWindow(); //İstersek basit bir pencere oluştururuz..
            Console.WriteLine(window1.GetDescription());
            Console.WriteLine(window1.Draw());

            Console.ReadLine();

            IWindow window2 = new HorizontalScrollbarWindow(new SimpleWindow()); //İstersek basit pencereyi yatay kaydırma çubukları ile dekore edebiliriz.
            Console.WriteLine(window2.GetDescription());
            Console.Write(window2.Draw());

            Console.ReadLine();

            IWindow window3 = new VerticalScrollbarWindow(new SimpleWindow()); //İstersek basit pencereyi dikey kaydırma çubukları ile dekore edebiliriz.
            Console.WriteLine(window3.GetDescription());
            Console.Write(window3.Draw());

            Console.ReadLine();

            IWindow window4 = new HorizontalScrollbarWindow(new VerticalScrollbarWindow(new SimpleWindow())); //İstersekte hem yatay hemde dikey kaydırma çubukları ile dekore edebiliriz..

            Console.WriteLine(window4.GetDescription());
            Console.WriteLine(window4.Draw());
            Console.Read();
        }
    }
}
