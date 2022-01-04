
using System.Drawing;

namespace command_pattern_lab.Interfaces
{
    public interface IReciever
    {
        void Up();
        void Down();
        void Left();
        void Right();
        Color CurrentColor();
        void ColorChange(Color color);
    }
}
