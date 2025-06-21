using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            _onStart?.Execute();

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            _onFinish?.Execute();
        }
    }
}
