using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TcpLib
{
    class PacketMonitor
    {

        public Packet packet;
        public bool ackReceived;
        private bool timeout;
        private Timer timer;


        public PacketMonitor(Packet packet)
        {
            this.packet = packet;
            ackReceived = false;
            timeout = true;
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 50;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            timeout = true;
        }

        public void resetTimer()
        {
            timer.Stop();
            timer.Start();
        }

        public bool checkTimeout()
        {
            if (!ackReceived && timeout)
            {
                return true;
            }
            return false;
        }



        






    }
}
