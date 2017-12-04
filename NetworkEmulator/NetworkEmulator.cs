using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TcpLib;

namespace NetworkEmulator
{
    class NetworkEmulator
    {
        private bool running;
        private int latency;
        private int variance;
        private int dropRate;
        Random random;

        public void Start(string IPOut, int PortOut, int PortListen )
        {
            random = new Random();
            running = true;
            
            CreateListener(IPOut, PortOut, PortListen);
        }

        public void stop()
        {
            running = false;
        }


        public void CreateListener(string destIP, int destPort, int Listenport)
        {
            Task.Factory.StartNew(() =>
            {
                TcpListener listener = new TcpListener(IPAddress.Any, Listenport);
                TcpClient destination = new TcpClient();
                if(!Connect(destination, destIP, destPort))
                {
                    return;
                }

                listener.Start();
                while (running)
                {
                    var client = listener.AcceptTcpClient();
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Client connected...");

                        CreateNetworkBridge(client, destination);
                        CreateNetworkBridge(destination, client);
                        
                        Console.WriteLine("Client disconnected...");
                    });
                }
                listener.Stop();
                destination.Close();
            });
        }

        private bool Connect(TcpClient client, string ip, int port)
        {
            try
            {
                client.Connect(ip, port);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }


        private void CreateNetworkBridge(TcpClient src, TcpClient dst)
        {
            Task.Factory.StartNew(() =>
            {
                var reader = new StreamReader(src.GetStream());
                var writer = new StreamWriter(dst.GetStream());
                Packet packet = Serializer.ReadObject<Packet>(reader);
                while (packet != null && running)
                {
                    InitiateDelay(packet);

                    if (!RollForDrop())
                    {
                        Serializer.SendObject(writer, packet);
                    }

                    packet = Serializer.ReadObject<Packet>(reader);
                }
                reader.Close();
                writer.Close();
            });
        }


        public void UpdateNetworkVariables(int latency, int variance, int dropRate)
        {
            this.latency = latency;
            this.variance = variance;
            this.dropRate = dropRate;
        }

        private void InitiateDelay(Packet packet)
        {
            int delay = latency + random.Next(0, variance+1);
            Thread.Sleep(delay);
        }

        private bool RollForDrop()
        {
            if (random.Next(0, 100) < dropRate)
            {
                return true;
            }
            return false;
        }

    }
}
