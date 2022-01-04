using command_pattern_lab.Interfaces;
using System.Drawing;

namespace command_pattern_lab.Commands
{
    public class CommandBlue : ICommand
    {
        IReciever device;
        Color oldColor = Color.DarkBlue;

        public CommandBlue(IReciever device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.oldColor = this.device.CurrentColor();
            this.device.ColorChange(Color.DarkBlue);
            
        }
        public void Undo()
        {
            this.device.ColorChange(oldColor);
        }   
    }
}
