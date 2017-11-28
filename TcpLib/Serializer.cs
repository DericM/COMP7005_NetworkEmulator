using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TcpLib
{
    public class Serializer
    {

        public static void SendObject<T>(StreamWriter s, T o)
        {
            s.WriteLine(JsonConvert.SerializeObject(o));
            s.Flush();
        }

        public static T ReadObject<T>(StreamReader r)
        {
            var line = r.ReadLine();
            if (line == null) return default(T);
            return JsonConvert.DeserializeObject<T>(line);
        }

    }
}
