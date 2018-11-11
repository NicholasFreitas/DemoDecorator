using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{

    /* The decorator pattern helps us to follow the Open / Close principle.
     * What it does it allow us to add functionality at run time, rather than compile time.
     * This is done by first having a component. Then we wrap that component with decorators.
     * (other objects) and each new wrapper adds new behavior.*/
    /*
     
         ------------             --------------
         |IComponent| <<-has-a--- |IDecorator  |
         ------------ <--is-a---- --------------
         |methoda() |             |methoda()   |
         ------------             --------------
              |  is-a                        | is-a
              |                              |
              V                              V
         -------------------    -------------------
         |ConcreteComponent|    |ConcreteDecorator|
         -------------------    -------------------
         |methoda()        |    |IComponent comp  |
         -------------------    -------------------
                                |methoda()        |
                                -------------------
         */

    class Program
    {
        static void Main(string[] args)
        {

            var DecOne = new ConcreteDecoratorOne(new ConcreteDecoratorTwo(new ConcreteDecoratorThree(new ConcreteComponent())));
            DecOne.MethodA();

            Console.ReadLine();




        }
    }
}
