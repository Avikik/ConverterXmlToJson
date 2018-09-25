using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlToJsonConverter.Core;

namespace XmlToJson.Tests
{
    [TestClass]
    public class UnitTestFilterArgsData
    {
        private FilterArgsData filter;
        private string[] args;
        [TestMethod]
        public void TestisFilterArgs()
        {
            args = new string[]
            {
                @"D:\22.xml",
                "myFile.json"
            };

            filter = new FilterArgsData(args);

            Assert.IsTrue(filter.isFilterArgs());
        }

        [TestMethod]
        public void TestisSearchFiles()
        {
            args = new string[]
            {
                @"D:\23.xml",
                "myFile.json"
            };

            filter = new FilterArgsData(args);

            Assert.IsFalse(filter.isFilterArgs());
        }
    }
}
