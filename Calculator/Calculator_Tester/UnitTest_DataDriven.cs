using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Tester
{
    [TestClass]
    public class UnitTest_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            
            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString();
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            operation.Remove(0, 1);

            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}
