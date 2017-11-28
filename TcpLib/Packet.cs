using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpLib
{
    [Serializable]
    public class Packet
    {

        public enum Type
        {
            Ack,
            Data
        };

        public Type PacketType { get; set; }
        public int SeqNum { get; set; }
        public int WindowSize { get; set; }
        public int AckNum { get; set; }
        public string Data { get; set; }

        public override string ToString()
        {
            return "PacketType: " + PacketType +
                " SeqNum: " + SeqNum +
                " WindowSize: " + WindowSize +
                " AckNum: " + AckNum +
                " Data: " + Data;
        }

        public static Packet ACK(int seq, int ack, int win)
        {
            return new Packet()
            {
                PacketType = Type.Ack,
                SeqNum = seq,
                WindowSize = win,
                AckNum = ack,
                Data = ""
            };
        }

        public static Packet DATA(int seq, int ack, int win, string data)
        {
            return new Packet()
            {
                PacketType = Type.Data,
                SeqNum = seq,
                WindowSize = win,
                AckNum = ack,
                Data = data
            };
        }

    }

}
