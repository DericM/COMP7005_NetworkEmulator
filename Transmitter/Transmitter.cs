using System;
using System.Net.Sockets;

namespace Sender
{
    class Transmitter
    {

        TcpClient client;
        SlidingWindow window;

        public bool Connect(string ip, int port)
        {
            try
            {
                client = new TcpClient();
                Console.WriteLine("Connecting.....");
                
                client.Connect(ip, port);

                Console.WriteLine("Connected");

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return false;
            }
        }


        public void StartDataStream(int windowSize, int packets)
        {
            window = new SlidingWindow(client, windowSize, packets);
        }


        public void Stop()
        {
            if (window != null)
            {
                window.Stop();
            }
            
        }

    }
}
