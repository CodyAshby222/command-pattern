using command_pattern_lab.Interfaces;

namespace command_pattern_lab.Commands
{
    public class CommandLeft : ICommand
    {
        IReciever device;

        public CommandLeft(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.Left();
        }
        public void Undo()
        {
            this.device.Right();
        }
    }
}
