using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class ConcreteDecoratorTwo : IDecorator
    {
        IComponent Component;

        public ConcreteDecoratorTwo(IComponent component)
        {
            Component = component;
        }
        public void MethodA()
        {
            Component.MethodA();
            MethodTwo();
        }

        void MethodTwo()
        {
            Console.WriteLine("Method Two Called");
        }

    }
}
