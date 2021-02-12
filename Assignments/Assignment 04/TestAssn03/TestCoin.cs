using _03._3_Coin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestAssn03
{
    [TestClass]
    public class TestCoin
    {
        [TestMethod]
        public void CreateSlug()
        {
            Coin testSlug = new Coin();
            Assert.IsTrue(testSlug.ValueOf == 0);
        }

        [TestMethod]
        public void CreateBadValueSlugViaString()
        {
            Coin testSlug = new Coin("222");
            Assert.IsTrue(testSlug.ValueOf == 0);
        }

        [TestMethod]
        public void CreateBadValueSlugViaDecimal()
        {
            Coin testSlug = new Coin(23M);
            Assert.IsTrue(testSlug.ValueOf == 0);
        }

        [TestMethod]
        public void CreateNickelViaDecimal()
        {
            Coin testNickel = new Coin(0.05M);
            Assert.IsTrue(testNickel.ValueOf == 0.05M);
        }

        [TestMethod]
        public void CreateDimeViaDenomination()
        {
            Coin testDime = new Coin(0.1M);
            Assert.IsTrue(testDime.ValueOf == 0.1M);
        }
    }
}
