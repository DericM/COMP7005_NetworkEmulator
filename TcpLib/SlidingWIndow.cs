using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpLib
{
    public class SlidingWindow
    {

        private Queue<PacketMonitor> window;
        private int sequence = 0;
        private int windowSize = 5;

        public SlidingWindow(int windowSize)
        {
            window = new Queue<PacketMonitor>();
            InitWindow();
        }

        private void InitWindow()
        {
            for (int i=0; i<windowSize; i++)
            {
                InsertPacket();
            }

            WindowThread();
        }

        private void WindowThread()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    ShiftWindow();
                }
                
            });
        }

        public void SendThread(StreamWriter streamWriter)
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    foreach (var i in window)
                    {
                        if (i.checkTimeout())
                        {
                            Serializer.SendObject(streamWriter, i.packet);
                            i.resetTimer();
                        }
                    }
                }

            });
        }

        public void AckThread(StreamReader streamReader)
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Packet packet = Serializer.ReadObject<Packet>(streamReader);
                    if (packet != null && packet.PacketType == Packet.Type.Ack)
                    {
                        HandelAck(packet.AckNum);
                    }
                }
            });
        }



        private bool ShiftWindow()
        {
            if (window.Peek().ackReceived)
            {
                InsertPacket(window.Dequeue());
                return true;
            }
            return false;
        }

        private void InsertPacket()
        {
            window.Enqueue(new PacketMonitor(NewPacket()));
        }

        private void InsertPacket(PacketMonitor pm)
        {
            pm.packet = NewPacket();
            window.Enqueue(pm);
        }

        private Packet NewPacket()
        {
            Packet newPacket = Packet.DATA(sequence, sequence, windowSize, "data");
            sequence++;
            return newPacket;
        }


        private void HandelAck(int ack)
        {
            foreach (var i in window)
            {
                if(i.packet.SeqNum == ack)
                {
                    i.ackReceived = true;
                    return;
                }
            }
        }

        






    }
}
