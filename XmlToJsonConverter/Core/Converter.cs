using System;
using System.Collections.Generic;


namespace XmlToJsonConverter.Core
{
    public class TextConverter
    {
        private string inputFileName;
        private string outPutFileName;
        FilterArgsData filter;
        public TextConverter(string[] args)
        {
            filter = new FilterArgsData(args);
            inputFileName = args[0];
            outPutFileName = args[1];                    
        }

        public void StartConverter()
        {
            if (filter.isFilterArgs())
            {
                ConvertedXmlToJson(inputFileName, outPutFileName);
            }
        }

        private void ConvertedXmlToJson(string inputFileName, string outPutFileName)
        {
            JsonCreater.CreateJsonFile(XmlParser.ParseXmlDocument(inputFileName), outPutFileName);
        }
       
    }
}
