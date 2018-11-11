using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class ConcreteDecoratorOne : IDecorator
    {
        IComponent Component;

        public ConcreteDecoratorOne(IComponent component)
        {
            Component = component;
        }

        public void MethodA()
        {
            Component.MethodA();
            MethodOne();
        }

        public void MethodOne()
        {
            Console.WriteLine("Method One Called");
        }

    }
}
