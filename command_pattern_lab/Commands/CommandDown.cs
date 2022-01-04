using command_pattern_lab.Interfaces;

namespace command_pattern_lab.Commands
{
    public class CommandDown : ICommand
    {
        IReciever device;

        public CommandDown(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.Down();
        }
        public void Undo()
        {
            this.device.Up();
        }
    }
}
