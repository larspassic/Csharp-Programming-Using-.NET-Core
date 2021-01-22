using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using _01_2_Hello_Core;

namespace _01_3_Hello_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(null);

            string result = sw.ToString();

            Assert.IsTrue(result.Contains("Hello") && result.Contains("Core"));
        }
    }
}
