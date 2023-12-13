using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    //ax+b=0
    //+VN : a = 0
    //+VSN: a=b=0
    //+1N: a!=0 => x=-b/a;

    [TestClass]
    public class UnitTest_SimpleEquation
    {
        [TestMethod]
        public void VoNghiem_Test()
        {
            SimpleEquation s = new SimpleEquation(0,3);
            Assert.AreEqual("VN", s.SingleEquation());
        }
        [TestMethod]
        public void VoSoNghiem_Test()
        {
            SimpleEquation s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());
        }
        [TestMethod]
        public void Co1Nghiem_Test()
        {
            SimpleEquation s = new SimpleEquation(3, -6);
            Assert.AreEqual("2", s.SingleEquation());
        }
    }
}
