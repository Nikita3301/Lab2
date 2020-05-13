using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] number = {8, -12, 34, 3, 6, 9, -45};
            uint length = 7;
            int k = 0;
            int k1 = 4;
            int result = Lab23._1.Program.Five(number, length, k);
            Assert.AreEqual(k1, result);
        }
    }
}