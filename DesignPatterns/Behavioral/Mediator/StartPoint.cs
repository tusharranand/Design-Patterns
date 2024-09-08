using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    class StartPoint
    {
        public void Main()
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
