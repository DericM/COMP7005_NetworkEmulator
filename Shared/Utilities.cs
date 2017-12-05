using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Shared
{
    public class Utilities
    {
        /*
         * https://stackoverflow.com/questions/6803073/get-local-ip-address
         */
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static void FormatLogEntries(DrawItemEventArgs e, ListBox listBox)
        {
            e.DrawBackground();
            if (e.Index < 0)
                return;

            Packet packet = (Packet)listBox.Items[e.Index];
            
            Color backgroundColor = Color.White;
            if (packet.Droped)
            {
                backgroundColor = Color.Black;
            }
            else
            {
                if (packet.Delay > 90)
                {
                    backgroundColor = Color.OrangeRed;
                }
                else if(packet.Delay > 60)
                {
                    backgroundColor = Color.DarkOrange;
                }
                else if (packet.Delay > 30)
                {
                    backgroundColor = Color.Orange;
                }

            }

            e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State,
                                          e.ForeColor,
                                          backgroundColor);//Choose the color

            e.DrawBackground();

            Brush myBrush = Brushes.Black;

            switch (packet.PacketType)
            {
                case Packet.Type.Ack:
                    myBrush = Brushes.Green;
                    break;
                case Packet.Type.Data:
                    myBrush = Brushes.Blue;
                    break;
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        public static void SaveFileDialogue(SaveFileDialog saveFileDialog, BindingList<Packet> packetLog)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SaveFile = new StreamWriter(saveFileDialog.FileName);
                foreach (var item in packetLog)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
            }
        }


    }
}
