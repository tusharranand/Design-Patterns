using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public class Client
    {
        public void ClientCode()
        {
            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            Console.Write(abstraction.Operation());

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            Console.Write(abstraction.Operation());
        }
    }
}
