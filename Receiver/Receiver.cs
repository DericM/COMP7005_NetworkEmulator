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
        public void connect()
        {
            Task.Factory.StartNew(() =>
            {
                TcpListener listener = new TcpListener(IPAddress.Any, 7005);
                listener.Start();
                while (true)
                {
                    var client = listener.AcceptTcpClient();
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Client connected...");
                        var reader = new StreamReader(client.GetStream());
                        var writer = new StreamWriter(client.GetStream());
                        Packet packet = Serializer.ReadObject<Packet>(reader);
                        while (packet != null)
                        {
                            Serializer.SendObject(writer, Packet.ACK(packet.SeqNum, packet.SeqNum, packet.WindowSize));

                            Console.WriteLine("[" + packet + "]");
                            packet = Serializer.ReadObject<Packet>(reader);
                        }
                        Console.WriteLine("Client disconnected...");
                    });
                }

            });
        }
        
    }
}
