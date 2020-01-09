using System.Collections.Generic;

namespace ToDoListMVP.Presenters
{
    public class CommandProcessor : ICommandProcessor
    {
        Stack<ICommand> cmdStack = new Stack<ICommand>();
        public void ExecuteCommand(ICommand cmd)
        {
            cmd.Execute();
            if (cmd.IsCompensable) cmdStack.Push(cmd);
        }

        public void CompensateLast()
        {
            if (cmdStack.Count > 0) cmdStack.Pop().Compensate();
        }
    }
}
