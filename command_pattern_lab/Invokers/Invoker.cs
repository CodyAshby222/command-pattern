using command_pattern_lab.Interfaces;

namespace command_pattern_lab.Invokers
{
    public class Invoker
    {
        ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }

        public void UndoCommand()
        {
            this.command.Undo();
        }
    }
}
