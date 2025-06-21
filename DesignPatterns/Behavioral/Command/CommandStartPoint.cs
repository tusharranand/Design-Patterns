using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    public static class CommandStartPoint
    {
        public static void CommandDemo()
        {
            Invoker invoker = new();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
