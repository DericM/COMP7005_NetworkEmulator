using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;
using TcpLib;

namespace Sender
{
    class Transmitter
    {

        TcpClient client;
        SlidingWindow window;

        public bool Connect(String ip, int port)
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
            window.Stop();
        }



       
        

    }

}
