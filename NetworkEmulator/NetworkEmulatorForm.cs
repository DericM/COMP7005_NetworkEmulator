using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpLib;

namespace NetworkEmulator
{
    public partial class NetworkEmulatorForm : Form
    {

        private NetworkEmulator networkEmulator;

        private BindingList<Packet> packetLogIn;
        private BindingList<Packet> packetLogOut;

        private bool running;


        public NetworkEmulatorForm()
        {
            InitializeComponent();

            networkEmulator = new NetworkEmulator();

            packetLogIn = new BindingList<Packet>();
            packetLogOut = new BindingList<Packet>();

            listBoxLogIn.DataSource = packetLogIn;
            listBoxLogOut.DataSource = packetLogOut;

            running = false;
            updateNetworkVariables();
        }


        public void LogIn(Packet newEntry)
        {
            listBoxLogIn.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                packetLogIn.Add(newEntry);
            });

        }

        public void LogOut(Packet newEntry)
        {
            listBoxLogIn.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                packetLogOut.Add(newEntry);
            });

        }

        private void listBoxLogIn_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based  
            // on the index of the item to draw. 
            switch (e.Index)
            {
                case 0:
                    myBrush = Brushes.Red;
                    break;
                case 1:
                    myBrush = Brushes.Orange;
                    break;
                case 2:
                    myBrush = Brushes.Purple;
                    break;
            }

            // Draw the current item text based on the current Font  
            // and the custom brush settings.
            e.Graphics.DrawString(listBoxLogIn.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
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
            int dropRate = (int)numericUpDownlatency.Value;
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
                running = true;

                string IPOut = textBoxB2OutIP.Text;
                int PortOut = (int)numericUpDownB2out.Value;
                int PortListen = (int)numericUpDownB2in.Value;

                networkEmulator.Start(IPOut, PortOut, PortListen);
                buttonStart.Text = "Stop";
                ToggleControls(false);
            }
        }


        private void ToggleControls(bool togle)
        {
            textBoxB2OutIP.Enabled = togle;
            numericUpDownB2out.Enabled = togle;
            numericUpDownB2in.Enabled = togle;
        }

    }
}
