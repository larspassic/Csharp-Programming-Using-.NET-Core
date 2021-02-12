using Exercise_03._2_Can;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAssn03
{
    [TestClass]
    public class TestCanRack
    {
        [TestMethod]
        public void RemoveACanViaFlavor()
        {
            CanRack rack = new CanRack();
            rack.RemoveACanOf(Flavor.LEMON);

            Assert.IsTrue(!rack.IsFull(Flavor.LEMON));
        }
    }
}
