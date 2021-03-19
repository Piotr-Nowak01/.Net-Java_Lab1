using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Generator()
        {
            RandomNumberGenerator nazwa = new RandomNumberGenerator(2137);
            int x = nazwa.nextInt(1,29);
            Assert.IsTrue (x >= 1 && x <= 29);
        }
    }
}
