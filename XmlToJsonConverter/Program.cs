
using System;
using XmlToJsonConverter.Core;
namespace XmlToJsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            TextConverter converter = new TextConverter(args);
            converter.StartConverter();
            Console.ReadKey();            
        }

        

    }
}
