using System;
using System.Collections.Generic;


namespace XmlToJsonConverter.Core
{
    public class TextConverter
    {
        private string inputFileName;
        private string outPutFileName;
        private string[] args;
        FilterArgsData filter;
        
        public TextConverter(string[] args)
        {
            this.args = args;
            filter = new FilterArgsData(args);                             
        }

        public void StartConverter()
        {
            if (isInputDataTrue())
                ConvertedXmlToJson(inputFileName, outPutFileName);
        }

        private bool isInputDataTrue()
        {
            if (filter.isFilterArgs())
            {
                inputFileName = args[0];
                outPutFileName = args[1];
                return true;
            }
            return false;
        }

        private void ConvertedXmlToJson(string inputFileName, string outPutFileName)
        {
            JsonCreater.CreateJsonFile(XmlParser.ParseXmlDocument(inputFileName), outPutFileName);
        }       
    }
}
