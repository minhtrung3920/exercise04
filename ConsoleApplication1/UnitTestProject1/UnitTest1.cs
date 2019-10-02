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
        [TestMethod]
        public void testPow()
        {
            double kq1 = Program.pow(2, 3);
            Assert.AreEqual(8, kq1);
            double kq2 = Program.pow(2, 0);
            Assert.AreEqual(1, kq2);
        }
        [TestMethod]
        public void testABS()
        {
            int kq1 = Program.abs(-4);
            Assert.AreEqual(4, kq1);
            int kq2 = Program.abs(8);
            Assert.AreEqual(8, kq2);
            int kq3 = Program.abs(0);
            Assert.AreEqual(1, kq3);
        }
        [TestMethod]
        public void testCeil()
        {
            int kq1 = Program.mathceil((float)4.2);
            Assert.AreEqual(5, kq1);
            int kq2 = Program.mathceil(0);
            Assert.AreEqual(0, kq2);
            int kq3 = Program.mathceil(5);
            Assert.AreEqual(5, kq3);
            int kq4 = Program.mathceil((float)-2.3);
            Assert.AreEqual(-2, kq4);
            int kq5 = Program.mathceil((float)0.1);
            Assert.AreEqual(1, kq5);
        }
        [TestMethod]
        public void testFloor()
        {
            int kq1 = Program.mathFloor(4.4);
            Assert.AreEqual(4, kq1);
            int kq2 = Program.mathFloor(-2.3);
            Assert.AreEqual(-3, kq2);
            int kq3 = Program.mathFloor(0);
            Assert.AreEqual(0, kq3);
            int kq4 = Program.mathFloor(0.1);
            Assert.AreEqual(0, kq4);
        }
        [TestMethod]
        public void testfactorial()
        {
            long kq1 = Program.factonrial(4);
            Assert.AreEqual(24, kq1);
        }

    }
}
