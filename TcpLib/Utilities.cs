using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TcpLib
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
            if (e.Index < 0)
                return;

            Packet packet = (Packet)listBox.Items[e.Index];

            Brush myBrush = Brushes.Black;

            if (packet.Droped)
            {
                myBrush = Brushes.Red;
                e.DrawBackground();
            }
            else
            {
                if (packet.Delay <= 0)
                {
                    myBrush = Brushes.White;
                }
                else
                {
                    myBrush = Brushes.Orange;
                }
                e.DrawBackground();
            }
            
            
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


    }
}
