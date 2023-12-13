using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Tester
{
    [TestClass]
    public class UnitTest_Caculation
    {

        Calculation cal;
        [TestInitialize]
        public void setUp()
        {
            cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOpretor()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOpretor()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOpretor()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOpretor()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            cal = new Calculation(5, 0);
            cal.Execute("/");
        }

    }
}
