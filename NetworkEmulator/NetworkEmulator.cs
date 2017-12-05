using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace NetworkEmulator
{
    class NetworkEmulator
    {
        
        private bool running;
        private int latency;
        private int variance;
        private int dropRate;
        Random random;

        TcpClient destination;

        public NetworkEmulator()
        {
            random = new Random();
            running = false;
        }

        public bool Start(string IPOut, int PortOut, int PortListen )
        {
            destination = new TcpClient();
            if (!Connect(destination, IPOut, PortOut))
            {
                return false;
            }
            running = true;
            CreateListener(PortListen);
            return true;
        }

        public void stop()
        {
            running = false;
        }


        public void CreateListener(int Listenport)
        {
            Task.Factory.StartNew(() =>
            {
                TcpListener listener = new TcpListener(IPAddress.Any, Listenport);
                
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
                    NetworkEmulatorForm.Instance.LogIn(packet);
                    InitiateDelay(packet);

                    if (!RollForDrop(packet))
                    {
                        Serializer.SendObject(writer, packet);
                        NetworkEmulatorForm.Instance.LogOut(packet);
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
            int delay = latency + random.Next(-variance, variance);
            packet.Delay = delay;
            Thread.Sleep(delay);
        }

        private bool RollForDrop(Packet packet)
        {
            int roll = random.Next(1, 101);
            Console.WriteLine("roll: " + roll + "dropRate: " + dropRate);
            if (roll < dropRate)
            {
                packet.Droped = true;
                return true;
            }
            packet.Droped = false;
            return false;
        }

    }
}
