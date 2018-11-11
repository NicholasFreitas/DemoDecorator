using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class ConcreteDecoratorThree : IDecorator
    {
        IComponent Component;

        public ConcreteDecoratorThree(IComponent component)
        {
            Component = component;
        }

        public void MethodA()
        {
            Component.MethodA();
            MethodThree();
        }

        void MethodThree()
        {
            Console.WriteLine("Method Three Called");
        }
    }
}
