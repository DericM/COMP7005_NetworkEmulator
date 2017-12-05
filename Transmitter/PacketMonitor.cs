using System.Timers;
using Shared;

namespace Sender
{
    public class PacketMonitor
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
            timer.Interval = 500;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            timeout = true;
        }

        public void resetTimer()
        {
            timeout = false;
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
