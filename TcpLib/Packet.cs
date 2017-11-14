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
        public int PacketType { get; set; }
        public int SeqNum { get; set; }
        public int WindowSize { get; set; }
        public int AckNum { get; set; }
        public string Data { get; set; }
    }
}
