using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;
using TcpLib;

namespace Sender
{
    class Sender
    {

        TcpClient transferClnt;
        Stream transferStream;

        public bool connect(String ip, int port)
        {
            try
            {
                transferClnt = new TcpClient();
                Console.WriteLine("Connecting.....");
                
                transferClnt.Connect(ip, 7004);
                
                transferStream = transferClnt.GetStream();

                Console.WriteLine("Connected");

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return false;
            }
        }


        public bool sendMultiplePackets(int n)
        {
            for(int i = 0; i < n; i++)
            {
                sendDataPacket(i);
            }
            return true;
        }




        public bool sendDataPacket(int Sequence)
        {
            var newPacket = new Packet
            {
                PacketType = 0,
                SeqNum = Sequence,
                WindowSize = 1,
                AckNum = 0,
                Data = "data"
            };

            string serializedPacket = JsonConvert.SerializeObject(newPacket);
            
            if (transferStream.CanWrite)
            {
                transferStream.Write(Encoding.UTF8.GetBytes(serializedPacket), 0, serializedPacket.Length);
                return true;
            }
            return false;
        }
        

    }

}
