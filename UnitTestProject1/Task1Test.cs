using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class Task1Test
    {
        Task1 t = new Task1();
        [TestMethod]
        public void functionTest()
        {
            int a = 5, b = 0, c = -10;

            Assert.AreEqual(0, t.function(a));
            Assert.AreEqual(0, t.function(b));
            Assert.AreEqual(19, t.function(c));
        }

        [TestMethod]
        public void changeTest()
        {
            int a = 2, b = 4;
            Assert.AreEqual((4, 2), t.change(a, b));
        }
    }

    [TestClass]
    public class Task2Test
    {
        Task2 t = new Task2();
        [TestMethod]
        public void MaxTest()
        {
            int a = 6, b = 9, c = 18;
            Assert.AreEqual(33, t.Max(a, b, c));
        }

        [TestMethod]
        public void SumTest()
        {
            int a = 500;
            Assert.AreEqual((5, 0), t.Sum(a));
        }
    }

    [TestClass]
    public class Task3Test
    {
        Task3 t = new Task3();
        [TestMethod]
        public void factorialTest()
        {
            int a = 4;
            Assert.AreEqual(24, t.factorial(a));
        }

        [TestMethod]
        public void MaxNumberTest()
        {
            int a = 500;
            Assert.AreEqual(5, t.MaxNumber(a));
        }
    }
}
