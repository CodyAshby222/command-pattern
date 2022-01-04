using command_pattern_lab.Interfaces;

namespace command_pattern_lab.Commands
{
    public class CommandRight : ICommand
    {
        IReciever device;

        public CommandRight(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.Right();
        }
        public void Undo()
        {
            this.device.Left();
        }
    }
}
