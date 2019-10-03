using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsconstraint5()
        {
            int[] arr = new int[] { 1, 2, 2, 3, 5 };
            bool result = Program.IsConstraint5(arr);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestIsconstraint5or6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result = Program.IsConstraint5or6(arr1);
            Assert.AreEqual(true, result);

            int[] arr2 = new int[] { 1, 2, 3, 4, 5};
            bool result2 = Program.IsConstraint5or6(arr2);
            Assert.AreEqual(true, result2);

            int[] arr3 = new int[] { 1, 2, 3, 4, 7, 8, 9 };
            bool result3 = Program.IsConstraint5or6(arr3);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void TestIsconstraint5and6()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result = Program.IsConstraint5and6(arr);
            Assert.AreEqual(true, result);

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            bool result2 = Program.IsConstraint5and6(arr2);
            Assert.AreEqual(false, result2);

            int[] arr3 = new int[] {1,23,7,8,9,10};
            bool result3 = Program.IsConstraint5and6(arr2);
            Assert.AreEqual(false, result3);    
        }
        [TestMethod]
        public void TestCount5()
        {
            int[] arr = new int[] { 1, 23, 4, 5, 6, 7, 8 };
            int result = Program.count(arr);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestCount5or6()
        {
            int[] arr = new int[] { 1, 2, 5, 6, 4, 7 };
            int result = Program.count2(arr);
            Assert.AreEqual(true, result);

            int[] arr2 = new int[] { 1, 2, 4, 5, 7 };
            int result2 = Program.count2(arr2);
            Assert.AreEqual(true, result2);

            int[] arr3 = new int[] { 1, 2, 6, 4, 7 };
            int result3 = Program.count2(arr3);
            Assert.AreEqual(true, result3);

        }
        [TestMethod]
        public void testsum()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int result = Program.sum(arr);
            Assert.AreEqual(21, result);
        }
    }
}
