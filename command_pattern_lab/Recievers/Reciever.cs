using command_pattern_lab.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace command_pattern_lab.Recievers
{
    public class Reciever : IReciever
    {
        PictureBox Square;
        public Color currentColor = Color.DarkRed;
 
        public Reciever(PictureBox Square)
        {
            this.Square = Square;
        }

        public void Down()
        {
            Square.Location = new Point(Square.Location.X, Square.Location.Y + 50);
        }

        public void Left()
        {
            Square.Location = new Point(Square.Location.X - 50, Square.Location.Y);
        }

        public void Right()
        {
            Square.Location = new Point(Square.Location.X + 50, Square.Location.Y);
        }

        public void Up()
        {
            Square.Location = new Point(Square.Location.X, Square.Location.Y - 50);
        }

        public void ColorChange(Color color)
        {
            currentColor = color;
            Square.BackColor = color;
        }

        public Color CurrentColor()
        {
            return currentColor;
        }
    }
}
