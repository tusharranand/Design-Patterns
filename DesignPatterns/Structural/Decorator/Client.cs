using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    public class Client
    {
        public void Main()
        {
            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            ClientCode(simple);
            Console.WriteLine();

            
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            ClientCode(decorator2);
        }
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
