using System.IO;
using Newtonsoft.Json;

namespace Shared
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
