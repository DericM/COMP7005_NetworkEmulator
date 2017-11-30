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
    class Sender
    {

        TcpClient client;
        StreamWriter streamWriter;
        StreamReader streamReader;
        SlidingWindow window;

        public bool Connect(String ip, int port)
        {
            try
            {
                client = new TcpClient();
                Console.WriteLine("Connecting.....");
                
                client.Connect(ip, 7005);
                streamWriter = new StreamWriter(client.GetStream());
                streamReader = new StreamReader(client.GetStream());

                Console.WriteLine("Connected");

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return false;
            }
        }


        public void StartDataStream()
        {
            window = new SlidingWindow(5);
            window.AckThread(streamReader);
            window.SendThread(streamWriter);
        }



       
        

    }

}
