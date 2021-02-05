using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExecutionSelection
{
    [TestClass]
    public class UnitTest1
    {
        private int testInstanceExecutionOrdinal;
        private static int overallExecutionOrdinal;

        private void incrementAndWriteOrdinals(string methodName)
        {
            System.Console.WriteLine("{0} : {1}, {2}", 
                methodName,
                ++overallExecutionOrdinal,
                ++testInstanceExecutionOrdinal);
        }

        [TestMethod]
        public void D_AndRun()
        {
            incrementAndWriteOrdinals("D");
        }

        [TestMethod]
        public void A_Tests()
        {
            incrementAndWriteOrdinals("A");
        }

        [TestMethod]
        public void E_Alphabetically()
        {
            incrementAndWriteOrdinals("E");
        }

        [TestMethod, TestCategory("Stress")]
        public void F_IrrespectiveOf()
        {
            incrementAndWriteOrdinals("F");
        }

        [TestMethod, TestCategory("Coverage")]
        public void G_Declaration()
        {
            incrementAndWriteOrdinals("G");
        }

        [TestMethod, TestCategory("Stress")]
        public void B_Are()
        {
            incrementAndWriteOrdinals("B");
        }

        [TestMethod, TestCategory("Coverage")]
        public void C_Listed()
        {
            incrementAndWriteOrdinals("C");
        }

    }
}
