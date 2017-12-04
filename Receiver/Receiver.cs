using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TcpLib;

namespace Receiver
{
    class Receiver
    {
        private bool running;

        public Receiver()
        {
            running = false;
        }

        public void Stop()
        {
            running = false;
        }

        public void Start(int port)
        {
            running = true;
            Task.Factory.StartNew(() =>
            {
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                while (running)
                {
                    var client = listener.AcceptTcpClient();
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Client connected...");
                        var reader = new StreamReader(client.GetStream());
                        var writer = new StreamWriter(client.GetStream());
                        Packet packet = Serializer.ReadObject<Packet>(reader);
                        while (packet != null && running)
                        {
                            ReceiverForm.Instance.Log(packet);
                            Packet ack = Packet.ACK(packet.SeqNum, packet.SeqNum, packet.WindowSize);
                            Serializer.SendObject(writer, ack);
                            ReceiverForm.Instance.Log(ack);
                            packet = Serializer.ReadObject<Packet>(reader);
                        }
                        Console.WriteLine("Client disconnected...");
                    });
                }
                listener.Stop();
            });
        }
        
    }
}
