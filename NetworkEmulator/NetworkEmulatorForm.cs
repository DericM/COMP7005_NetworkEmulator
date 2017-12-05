using System;
using System.ComponentModel;
using System.Windows.Forms;
using Shared;
using System.IO;

namespace NetworkEmulator
{
    public partial class NetworkEmulatorForm : Form
    {
        private static NetworkEmulatorForm _instance;
        private NetworkEmulator networkEmulator;

        private BindingList<Packet> packetLogIn;
        private BindingList<Packet> packetLogOut;

        private bool running;

        public static NetworkEmulatorForm Instance { get { return _instance; } }

        public NetworkEmulatorForm()
        {
            InitializeComponent();
            _instance = this;

            networkEmulator = new NetworkEmulator();

            packetLogIn = new BindingList<Packet>();
            packetLogOut = new BindingList<Packet>();

            listBoxLogIn.DataSource = packetLogIn;
            listBoxLogOut.DataSource = packetLogOut;
            listBoxLogIn.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxLogOut.DrawMode = DrawMode.OwnerDrawFixed;

            running = false;
            updateNetworkVariables();
        }


        public void LogIn(Packet newEntry)
        {
            listBoxLogIn.Invoke((MethodInvoker)delegate {
                packetLogIn.Add(newEntry);
                listBoxLogIn.TopIndex = listBoxLogIn.Items.Count - 1;
                listBoxLogIn.SelectedIndex = listBoxLogIn.Items.Count - 1;
            });

        }

        public void LogOut(Packet newEntry)
        {
            listBoxLogOut.Invoke((MethodInvoker)delegate {
                packetLogOut.Add(newEntry);
                listBoxLogOut.TopIndex = listBoxLogOut.Items.Count - 1;
                listBoxLogOut.SelectedIndex = listBoxLogOut.Items.Count - 1;
            });

        }

        private void listBoxLogIn_DrawItem(object sender, DrawItemEventArgs e)
        {
            Utilities.FormatLogEntries(e, listBoxLogIn);
        }

        private void NetworkEmulatorForm_Load(object sender, EventArgs e)
        {
            textBoxHostIP.Text = Utilities.GetLocalIPAddress();
        }
        

        private void trackBarDrop_Scroll(object sender, EventArgs e)
        {
            updateNetworkVariables();
        }

        private void numericUpDownlatency_ValueChanged(object sender, EventArgs e)
        {
            updateNetworkVariables();
        }

        private void numericUpDownVariance_ValueChanged(object sender, EventArgs e)
        {
            updateNetworkVariables();
        }

        private void updateNetworkVariables()
        {
            textBoxPercent.Text = "%" + trackBarDrop.Value;
            int dropRate = trackBarDrop.Value;
            int latency = (int)numericUpDownlatency.Value;
            int variance = (int)numericUpDownVariance.Value;

            networkEmulator.UpdateNetworkVariables(latency, variance, dropRate);
        }

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (running)
            {
                running = false;
                networkEmulator.stop();
                buttonStart.Text = "Start";
                ToggleControls(true);
            }
            else
            {
                string IPOut = textBoxB2OutIP.Text;
                int PortOut = (int)numericUpDownB2out.Value;
                int PortListen = (int)numericUpDownB2in.Value;
                if (networkEmulator.Start(IPOut, PortOut, PortListen))
                {
                    running = true;
                    buttonStart.Text = "Stop";
                    ToggleControls(false);
                }
            }
        }


        private void ToggleControls(bool togle)
        {
            textBoxB2OutIP.Enabled = togle;
            numericUpDownB2out.Enabled = togle;
            numericUpDownB2in.Enabled = togle;
        }

        private void listBoxLogOut_DrawItem(object sender, DrawItemEventArgs e)
        {
            Utilities.FormatLogEntries(e, listBoxLogOut);
        }


        private void buttonSaveInLog_Click(object sender, EventArgs e)
        {
            Utilities.SaveFileDialogue(saveFileDialog, packetLogIn);
        }

        private void buttonSaveOutLog_Click(object sender, EventArgs e)
        {
            Utilities.SaveFileDialogue(saveFileDialog, packetLogOut);
        }
    }
}
