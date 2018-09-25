using System;
using System.IO;

namespace XmlToJsonConverter.Core
{
   public class FilterArgsData
    {
        private TestInputArgs testInput;
        private TestFileName testFileName;
        private string inputFileName;
        private string[] args;
        public FilterArgsData(string[] args)
        {
            this.args = args;            
            testInput = new TestInputArgs(args);            
        }

        public bool isFilterArgs()
        {
            return isFilterNameArgs() && SearchFiles(inputFileName);
        }
      
        private bool isFilterNameArgs()
        {         
            return isInputDataOK() && testFileName.TestFileNameType();
        }

        private bool isInputDataOK()
        {
            if (testInput.isCountArgsOk())
                return IntializationFileNameArgs();
            return false;             
        }

        private bool IntializationFileNameArgs()
        {
            testFileName = new TestFileName(args[0], args[1]);
            inputFileName = args[0];
            return true;
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
