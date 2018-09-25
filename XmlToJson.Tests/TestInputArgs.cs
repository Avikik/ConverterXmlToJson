using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlToJsonConverter.Core;
namespace XmlToJson.Tests
{
    [TestClass]
    public class TestInputArgsUnit
    {
        string[] args;
        TestInputArgs testInputArgs;

        [TestMethod]
        public void TestIsCountArgsOk()
        {
            args = new string[]
            {
                @"D:inputFile.xml",
                @"outPutFile.json"
            };
            testInputArgs  = new TestInputArgs(args);

            Assert.IsTrue(testInputArgs.isCountArgsOk());
        }

        [TestMethod]
        public void TestIsCountArgsMoreTwo()
        {
            args = new string[]
            {
                @"D:inputFile.xml",
                @"outPutFile.json",
                @"outPutFile.json"
            };
            testInputArgs = new TestInputArgs(args);

            Assert.IsFalse(testInputArgs.isCountArgsOk());
        }

        [TestMethod]
        public void TestIsCountArgsZero()
        {
            args = new string[]{};
            testInputArgs = new TestInputArgs(args);
            Assert.IsFalse(testInputArgs.isCountArgsOk());
        }

        [TestMethod]
        public void TestIsCountArgsOne()
        {
            args = new string[]
            {
                @"D:inputFile.xml"
            };
            testInputArgs = new TestInputArgs(args);
            Assert.IsFalse(testInputArgs.isCountArgsOk());
        }
    }
}
