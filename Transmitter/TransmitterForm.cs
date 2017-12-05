using System;
using System.ComponentModel;
using System.Windows.Forms;
using Shared;
using System.IO;

namespace Sender
{
    public partial class TransmitterForm : Form
    {
        private static TransmitterForm _instance;
        private Transmitter transmitter;
        private BindingList<Packet> packetLog;
        private bool connected;
        

        public static TransmitterForm Instance { get { return _instance; } }

        public TransmitterForm()
        {
            InitializeComponent();
            _instance = this;
            connected = false;
            packetLog = new BindingList<Packet>();

            listBoxLog.DataSource = packetLog;
            listBoxLog.DrawMode = DrawMode.OwnerDrawFixed;
            TogleSendForms(false);
        }

        private void SenderForm_Load(object sender, EventArgs e)
        {
            textBoxHostIP.Text = Utilities.GetLocalIPAddress();
            transmitter = new Transmitter();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int windowSize = (int)numericUpDownWinSize.Value;
            int nunPackers = (int)numericUpDownNumPackets.Value;
            transmitter.StartDataStream(windowSize, nunPackers);
        }

        public void Log(Packet newEntry){
            listBoxLog.Invoke((MethodInvoker)delegate {
                packetLog.Add(newEntry);
                listBoxLog.TopIndex = listBoxLog.Items.Count - 1;
                listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            });
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                connected = false;
                transmitter.Stop();
                TogleConnectForms(true);
                TogleSendForms(false);
            }
            else
            {
                string ip = textBoxIP.Text;
                int port = (int)numericUpDownPort.Value;
                if(transmitter.Connect(ip, port))
                {
                    connected = true;
                    TogleConnectForms(false);
                    TogleSendForms(true);
                }
            }
            
        }

        private void TogleConnectForms(bool togle)
        {
            textBoxIP.Enabled = togle;
            numericUpDownPort.Enabled = togle;
        }

        private void TogleSendForms(bool togle)
        {
            numericUpDownNumPackets.Enabled = togle;
            numericUpDownWinSize.Enabled = togle;
            buttonSend.Enabled = togle;
        }

        private void listBoxLog_DrawItem(object sender, DrawItemEventArgs e)
        {
            Utilities.FormatLogEntries(e, listBoxLog);
        }

        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            Utilities.SaveFileDialogue(saveFileDialog, packetLog);
        }
    }
}
