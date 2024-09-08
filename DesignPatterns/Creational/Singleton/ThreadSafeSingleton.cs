using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton
{
    internal class ThreadSafeSingleton
    {
        private ThreadSafeSingleton() { }

        private static ThreadSafeSingleton _instance;

        private static readonly object _lock = new object();

        public static ThreadSafeSingleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }
    }
}
