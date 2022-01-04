using command_pattern_lab.Interfaces;
using System.Drawing;

namespace command_pattern_lab.Commands
{
    public class CommandGreen : ICommand
    {
        IReciever device;
        Color oldColor = Color.Green;

        public CommandGreen(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.oldColor = this.device.CurrentColor();
            this.device.ColorChange(Color.Green);
        }
        public void Undo()
        {
            this.device.ColorChange(oldColor);
        }
    }
}
