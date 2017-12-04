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
        private static ReceiverForm _instance;
        private Receiver receiver;
        private bool running;
        private BindingList<Packet> packetLog;

        public static ReceiverForm Instance { get { return _instance; } }

        public ReceiverForm()
        {
            InitializeComponent();
            _instance = this;
            running = false;
            packetLog = new BindingList<Packet>();

            listBoxLog.DataSource = packetLog;
        }

        public void Log(Packet newEntry)
        {
            listBoxLog.Invoke((MethodInvoker)delegate {
                packetLog.Add(newEntry);
            });
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
