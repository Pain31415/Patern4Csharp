using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern4Csharp
{
    public class RemoteControl
    {
        private List<ICommand> commands;

        public RemoteControl()
        {
            commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
