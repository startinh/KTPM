using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace Calculator_Tester
{
    [TestClass]
    public class PowerUnitTest
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\Data_Power.csv", "Data_Power#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPower()
        {
            int x = int.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());

            Assert.AreEqual(expected, Power.Power(x, n)); 
        }
    }
}
