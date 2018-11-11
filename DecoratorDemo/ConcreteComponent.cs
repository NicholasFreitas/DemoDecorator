using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class ConcreteComponent : IComponent
    {
        public void MethodA()
        {
            Console.WriteLine("Concrete Component Method");
        }
    }
}
