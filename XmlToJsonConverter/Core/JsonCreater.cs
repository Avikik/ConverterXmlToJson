using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlToJsonConverter.Model;
using Newtonsoft.Json;
using System.IO;

namespace XmlToJsonConverter.Core
{
    public class JsonCreater
    {
        public static void CreateJsonFile(List<Layer> complitedFile, string outPutFileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(outPutFileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, complitedFile);
            }

            Console.WriteLine("Файл успешно сконвертирован и находится - {0}", outPutFileName);
        }

    }
}
