using command_pattern_lab.Clients;
using command_pattern_lab.Commands;
using command_pattern_lab.Interfaces;
using command_pattern_lab.Invokers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace command_pattern_lab
{
    public partial class Command_Form : Form
    {
        public IReciever reciever;
        public List<Invoker> invokersList = new List<Invoker>();

        public Command_Form()
        {
            InitializeComponent();
            reciever = new Client(Square).getClient();
        }

        private void Up_Btn_Click(object sender, EventArgs e)
        {
            ICommand turnUpCommand = new CommandUp(reciever);
            Invoker invokeUp = new Invoker(turnUpCommand);
            invokersList.Add(invokeUp);
            invokersList.Last().ExecuteCommand();
        }

        private void Right_Btn_Click(object sender, EventArgs e)
        {
            ICommand turnRightCommand = new CommandRight(reciever);
            Invoker invokeRight = new Invoker(turnRightCommand);
            invokersList.Add(invokeRight);
            invokersList.Last().ExecuteCommand();
        }

        private void Left_Btn_Click(object sender, EventArgs e)
        {
            ICommand turnLeftCommand = new CommandLeft(reciever);
            Invoker invokeLeft = new Invoker(turnLeftCommand);
            invokersList.Add(invokeLeft);
            invokersList.Last().ExecuteCommand();
        }

        private void Down_Btn_Click(object sender, EventArgs e)
        {
            ICommand turnDownCommand = new CommandDown(reciever);
            Invoker invokeDown = new Invoker(turnDownCommand);
            invokersList.Add(invokeDown);
            invokersList.Last().ExecuteCommand();
        }

        private void Red_Btn_Click(object sender, EventArgs e)
        {
            ICommand redCommand = new CommandRed(reciever);
            Invoker invokeRed = new Invoker(redCommand);
            invokersList.Add(invokeRed);
            invokersList.Last().ExecuteCommand();
        }

        private void Green_Btn_Click(object sender, EventArgs e)
        {
            ICommand greenCommand = new CommandGreen(reciever);
            Invoker invokeGreen = new Invoker(greenCommand);
            invokersList.Add(invokeGreen);
            invokersList.Last().ExecuteCommand();
        }

        private void Blue_Btn_Click(object sender, EventArgs e)
        {
            ICommand blueCommand = new CommandBlue(reciever);
            Invoker invokeBlue = new Invoker(blueCommand);
            invokersList.Add(invokeBlue);
            invokersList.Last().ExecuteCommand();
        }

        private void Undo_Btn_Click(object sender, EventArgs e)
        {
            if (invokersList.Count > 0)
            {
                invokersList.Last().UndoCommand();
                invokersList.RemoveAt(invokersList.Count - 1);
            }
        }

        private void Square_Click(object sender, EventArgs e)
        {

        }
    }
}
