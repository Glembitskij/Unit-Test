using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 20;

            Calculator calculator = new Calculator();
            int res = calculator.Sum(a, b);

            Assert.AreEqual(res, 30);
        }
    }
}
