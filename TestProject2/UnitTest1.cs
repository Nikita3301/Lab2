using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] number = {8, -12, 34, 3, 6, 9, -45};
            uint length = 7;
            int m = 2;
            int sum = 0;
            int sum1 = 3 + 6 + 9 - 45;
            int result2 = Lab23._1.Program.Sum(number, sum, m, length);
            Assert.AreEqual(sum1, result2);
        }
    }
}