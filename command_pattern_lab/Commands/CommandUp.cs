using command_pattern_lab.Interfaces;

namespace command_pattern_lab.Commands
{
    public class CommandUp : ICommand
    {
        IReciever device;

        public CommandUp(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.Up();
        }
        public void Undo()
        {
            this.device.Down();
        }
    }
}
