using command_pattern_lab.Interfaces;
using command_pattern_lab.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace command_pattern_lab.Clients
{
    public class Client
    {
        PictureBox Square;
        public Client(PictureBox Square)
        {
            this.Square = Square;
        }
        public IReciever getClient()
        {
            return new Reciever(Square);
        }
    }
}
