using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
