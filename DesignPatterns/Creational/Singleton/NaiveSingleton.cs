using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton
{
    public sealed class NaiveSingleton
    {
        private NaiveSingleton() { }

        private static NaiveSingleton _instance;

        public static NaiveSingleton GetInstance()
        {
            _instance ??= new NaiveSingleton();
            return _instance;
        }

        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public void someBusinessLogic()
        {
            // ...
        }

    }
}
