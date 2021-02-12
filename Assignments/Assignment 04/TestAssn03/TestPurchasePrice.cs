using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_03._2_Can;

namespace TestAssn03
{
    [TestClass]
    public class TestPurchasePrice
    {
        [TestMethod]
        public void TestDecimalPrice()
        {
            PurchasePrice p = new PurchasePrice(35.1M);

            Assert.IsTrue(p.PriceDecimal == 35.1M);
        }
    }
}
