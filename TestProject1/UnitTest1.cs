using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 7;
            string c = "початкова: Погулянка\nкiнцева: церква святої Анни";
            string result = Lab21.Program.Number(number);
            Assert.AreEqual(c, result);

        }
    }
}