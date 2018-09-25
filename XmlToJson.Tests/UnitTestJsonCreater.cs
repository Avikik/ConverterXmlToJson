using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlToJsonConverter.Model;
using XmlToJsonConverter.Core;
using System.Collections.Generic;
using System.IO;

namespace XmlToJson.Tests
{
    [TestClass]
    public class UnitTestJsonCreater
    {
        private string CreaterJson()
        {
            //Перед применением этого теста настоятельно рекомендую указать путь до вашего файла типа xml
            //После одного использования, поменяйте название выходного файла,т.к. будет созадана копия с другим именем
            //и тесты не будут пройдены из-за разных имен выходных данных.
            string outFileName = "myTestJsonFile.json";
            List<Layer> listLayer = XmlParser.ParseXmlDocument(@"D:\22.xml");
            JsonCreater.CreateJsonFile(listLayer, outFileName);

            return outFileName;
        }
        [TestMethod]
        public void TestJsonCreater()
        {
            Assert.IsTrue(File.Exists(CreaterJson()));
        }
    }
}
