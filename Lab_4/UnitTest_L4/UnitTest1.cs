using System;
using Lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_L4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSinForZero()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Sin(0);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSinForPositive()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Sin(27.4);
            var expected = -0.64;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSinForNegative()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Sin(-36.6);
            var expected = 0.45;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSinForLarge()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Sin(0.42e12);
            var expected = -0.82;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCosForZero()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Cos(0);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCosForPositive()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Cos(12.4);
            var expected = 0.17;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCosForNegative()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Cos(-45.1);
            var expected = 0.9;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCosForLarge()
        {
            var d_calc = new Derivatives_Calculator();
            var actual = d_calc.Cos(0.7e18);
            var expected = -0.24;
            Assert.AreEqual(expected, actual);
        }
    }
}
