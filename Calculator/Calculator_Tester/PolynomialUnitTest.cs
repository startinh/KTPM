using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Calculator_Tester
{
    [TestClass]
    public class PolynomialUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn1()
        {
            int n = 2;
            List<int> list = new List<int> { 1, 2 };
            Polynomial p = new Polynomial(n, list);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn2()
        {
            int n = 2;
            List<int> list = new List<int> { 1, 2, 3, 4 };
            Polynomial p = new Polynomial(n, list);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn3()
        {
            int n = -1;
            List<int> list = new List<int> { };
            Polynomial p = new Polynomial(n, list);
        }

        [TestMethod]
        public void TestPolyn4_Dung()
        {
            int n = 2;
            List<int> list = new List<int> { 1, 2, 3 };
            Polynomial p = new Polynomial(n, list);
            int x = 1, expected = 6;
            Assert.AreEqual(expected, p.Cal(x));
        }

    }
}
