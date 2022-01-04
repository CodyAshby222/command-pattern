using command_pattern_lab.Interfaces;
using System.Drawing;

namespace command_pattern_lab.Commands
{
    public class CommandRed : ICommand
    {
        IReciever device;
        Color oldColor = Color.DarkRed;

        public CommandRed(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.oldColor = this.device.CurrentColor();
            this.device.ColorChange(Color.DarkRed);
        }
        public void Undo()
        {
            this.device.ColorChange(oldColor);
        }
    }
}
