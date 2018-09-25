using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlToJsonConverter.Core;
namespace XmlToJson.Tests
{
    [TestClass]
    public class UnitTestFileName
    {
        TestFileName testFileName;

        [TestMethod]
        public void TestFileNameType()
        {
            testFileName = new TestFileName(@"D:\inputFile.xml","outPutFile.json");
            Assert.IsTrue(testFileName.TestFileNameType());
        }
        [TestMethod]
        public void TestisTestInputFileXmlType()
        {
            testFileName = new TestFileName(@"D:\inputFile.json", "outPutFile.json");
            Assert.IsFalse(testFileName.TestFileNameType());
        }

        [TestMethod]
        public void TestisTestInputFileJsonType()
        {
            testFileName = new TestFileName(@"D:\inputFile.xml", "outPutFile.xml");
            Assert.IsFalse(testFileName.TestFileNameType());
        }

        [TestMethod]
        public void TestisCountPiecesNotEqualTwo()
        {
            testFileName = new TestFileName(@"D:\inputFile.html.xml", "outPutFile.json");
            Assert.IsFalse(testFileName.TestFileNameType());
        }
       
    }
}
