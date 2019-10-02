using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result1 = Program.IsOdd(3);
            Assert.AreEqual(true, result1);

            bool result2 = Program.IsOdd(4);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result3 = Program.IsEven(5);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsEven(6);
            Assert.AreEqual(true, result4);
        }
        [TestMethod]
        public void TestIsPrime()
        {
            bool result1 = Program.IsPrime(1);
            Assert.AreEqual(true, result1);
            bool result2 = Program.IsPrime(0);
            Assert.AreEqual(false, result2);
            bool result = Program.IsPrime(2);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestSquareCube()
        {
            int result1 = Program.Square(2);
            Assert.AreEqual(4, result1);
            int result2 = Program.Cube(3);
            Assert.AreEqual(9, result2);
        }

    }
}
