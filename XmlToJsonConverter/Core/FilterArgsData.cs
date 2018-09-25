using System;
using System.IO;

namespace XmlToJsonConverter.Core
{
   public class FilterArgsData
    {
        private TestInputArgs testInput;
        private TestFileName testFileName;
        private string inputFileName;
        public FilterArgsData(string[] args)
        {
            inputFileName = args[0];
            testInput = new TestInputArgs(args);
            testFileName = new TestFileName(args[0], args[1]);
        }

        public bool isFilterArgs()
        {
            return isFilterNameArgs() && SearchFiles(inputFileName);
        }
        private bool isFilterNameArgs()
        {         
            return testInput.isCountArgsOk() && testFileName.TestFileNameType();
        }

        private bool SearchFiles(string inputFileName)
        {
            if (!File.Exists(inputFileName))
            {
                Console.WriteLine("ERROR Файл не найден");
                return false;
            }
            return true;           
        }

    }
}
