using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 2;
            double y = Math.Log10(x) / (4 * x + 13);
            double result = Lab22.Program.Calc(x);
            Assert.AreEqual(y, result);

        }
    }
}