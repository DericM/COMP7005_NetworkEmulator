using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TcpLib;

namespace Sender
{
    class Sender
    {

        TcpClient client;
        StreamWriter streamWriter;
        StreamReader streamReader;

        public bool connect(String ip, int port)
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



        public void startDataStream()
        {
            int seq = 0;
            int ack = 0;
            int window = 5;
            
            while (true)
            {
                sendWindow(seq, window);
                seq += window;
                
            }

            

        }


        public void sendWindow(int seq, int windowSize)
        {
            for (int i= seq; i < seq + windowSize; i++)
            {
                sendDataPacket(i);
            }
        }



        public void ackReceiver()
        {
            Task.Factory.StartNew(() =>
            {
                Packet packet = Serializer.ReadObject<Packet>(streamReader);
                if(packet != null)
                {
                    
                }
            });
        }




        public void sendDataPacket(int seq, int ack, int win)
        {
            Packet newPacket = Packet.DATA(seq, ack, win, "data");

            Serializer.SendObject(streamWriter, newPacket);
        }
        

    }

}
