using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlToJsonConverter.Core;
using XmlToJsonConverter.Model;
namespace XmlToJson.Tests
{
    [TestClass]
    public class UnitTestXmlParser
    {
        [TestMethod]
        public void TestParseXmlDocument()
        {
            //Для удачного прохождения этого теста, вам нужно указать путь до файла с типом xml
            Assert.IsInstanceOfType(XmlParser.ParseXmlDocument(@"D:\22.xml"), typeof(List<Layer>));
        }
    }
}
