using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using Shared;

namespace Sender
{
    public class SlidingWindow
    {

        private Queue<PacketMonitor> window;
        private Queue<int> acks;
        private int sequence;
        private int windowSize;
        private int numPackets;
        private bool running;

        private StreamWriter streamWriter;
        private StreamReader streamReader;

        public SlidingWindow(TcpClient client, int wSize, int packets)
        {
            window = new Queue<PacketMonitor>();
            acks = new Queue<int>();
            streamWriter = new StreamWriter(client.GetStream());
            streamReader = new StreamReader(client.GetStream());

            windowSize = wSize;
            numPackets = packets;
            sequence = 0;
            InitWindow();
        }

        public void Stop()
        {
            running = false;
        }

        private void InitWindow()
        {
            running = true;
            for (int i=0; i<windowSize; i++)
            {
                InsertPacket();
            }
            AckThread();
            WindowThread();
        }

        private void WindowThread()
        {
            Task.Factory.StartNew(() =>
            {
                while (running)
                {
                    HandelAcks();
                    ShiftWindow();
                    SendPackets();
                }
            });
        }

        

        public void AckThread()
        {
            Task.Factory.StartNew(() =>
            {
                while (running)
                {
                    Packet packet = Serializer.ReadObject<Packet>(streamReader);
                    TransmitterForm.Instance.Log(packet);
                    if (packet != null && packet.PacketType == Packet.Type.Ack)
                    {
                        acks.Enqueue(packet.AckNum);
                    }
                }
            });
        }


        private void HandelAcks()
        {
            while (acks.Count > 0)
            {
                int ack = acks.Dequeue();
                foreach (var i in window)
                {
                    if (i.packet.SeqNum == ack)
                    {
                        i.ackReceived = true;
                    }
                }
            }
        }

        private void ShiftWindow()
        {
            while (window.Count > 0 && window.Peek().ackReceived)
            {
                window.Dequeue();
                InsertPacket();
            }
            if (window.Count == 0)//check if the window has sent all paclets
            {
                Stop();
            }
        }

        public void SendPackets()
        {
            foreach (var i in window)
            {
                if (i.checkTimeout())
                {
                    TransmitterForm.Instance.Log(i.packet);
                    Serializer.SendObject(streamWriter, i.packet);
                    i.resetTimer();
                }
            }
            
        }

        private void InsertPacket()
        {
            if (numPackets-- <= 0)
            {
                return;
            }
            window.Enqueue(new PacketMonitor(NewPacket()));
        }


        private Packet NewPacket()
        {
            Packet newPacket = Packet.DATA(sequence, sequence, windowSize, "data");
            sequence++;
            return newPacket;
        }

    }
}
