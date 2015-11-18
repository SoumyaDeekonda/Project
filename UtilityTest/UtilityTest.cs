using CalculatorUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatoUtilitiesTest
{
    [TestClass]
    public class UtilityTest
    {
        [TestMethod]
        public void WantToChangeZeroToNumber()
        {
            Utility uti = new Utility();
            var add = uti.RemovePrecedingZero("0", "1");
            Assert.AreEqual("1", add);
        }
        [TestMethod]
        public void WantToChangeZeroToZero()
        {
            Utility uti = new Utility();
            var add = uti.RemovePrecedingZero("0", "0");
            Assert.AreEqual("0", add);
        }
    }
}
