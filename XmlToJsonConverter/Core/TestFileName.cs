using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToJsonConverter.Core
{
    public class TestFileName
    {
        private string InputFileName;
        private string OutPutFileName;

        public TestFileName(string inputFile, string outPutFile)
        {
            InputFileName = inputFile;
            OutPutFileName = outPutFile;
        }

        public bool TestFileNameType()
        {
            return isTestInputFileXmlType() && isTestInputFileJsonType();
        }
        private bool isTestInputFileXmlType()
        {
            string[] piecesFileName = InputFileName.Split('.');
            return !(
                        isCountPiecesNotEqualTwo(piecesFileName, "xml") ||
                        isEndFileNameNotEqualType(piecesFileName,"xml")
                    );                              
        }

        private bool isTestInputFileJsonType()
        {
            string[] piecesFileName = OutPutFileName.Split('.');
            return !(
                        isCountPiecesNotEqualTwo(piecesFileName,"json") ||
                        isEndFileNameNotEqualType(piecesFileName,"json")
                    );
        }

        private bool isCountPiecesNotEqualTwo(string[] piecesName,string fileType)
        {
            if (piecesName.Length != 2)
            {
                Console.WriteLine("ERROR!Вы ввели не верное название файла.Оно должно быть формата fileName.{0}", fileType);
                return true;
            }
            return false;
        }

        private bool isEndFileNameNotEqualType(string[] piecesName,string fileType)
        {
            if (piecesName[piecesName.Length - 1] != fileType)
            {
                Console.WriteLine("ERROR!Вы указали не верный формат файла.Он должен быть формата .{0}", fileType);
                return true;
            }
            return false;
        }


    }
}
