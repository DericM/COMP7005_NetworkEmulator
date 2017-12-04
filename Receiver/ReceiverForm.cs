using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpLib;

namespace Receiver
{
    public partial class ReceiverForm : Form
    {
        private Receiver receiver;
        private bool running;

        public ReceiverForm()
        {
            InitializeComponent();
            running = false;
        }

        private void ReceiverForm_Load(object sender, EventArgs e)
        {
            receiver = new Receiver();
            textBoxHostIP.Text = Utilities.GetLocalIPAddress();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (running)
            {
                running = false;
                receiver.Stop();
                buttonConnect.Text = "Start";
                TogleForms(true);
            }
            else
            {
                int ip = (int)numericUpDownPort.Value;
                running = true;
                receiver.Start(ip);
                buttonConnect.Text = "Stop";
                TogleForms(false);
            }
        }

        private void TogleForms(bool togle)
        {
            numericUpDownPort.Enabled = togle;
        }
    }
}
