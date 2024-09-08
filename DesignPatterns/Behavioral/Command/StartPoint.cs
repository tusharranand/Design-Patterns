using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    public class StartPoint
    {
        public void Main()
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
