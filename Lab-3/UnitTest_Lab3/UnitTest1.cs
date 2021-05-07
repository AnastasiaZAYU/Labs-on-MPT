using System;
using Lab_3;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Lab3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveTest()
        {
            var app = new Lab_Mutex();
            var thread = new Thread(FirstT);
            thread.Start();
            bool val = false;
            void FirstT()
            {
                val = app.Start();
            }
            var expected = true;
            var actual = val;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeTest()
        {
            var app = new Lab_Mutex();
            var thread1 = new Thread(First);
            thread1.Start();
            bool val1 = false;
            void First()
            {
                val1 = app.Start();
            }
            var thread2 = new Thread(Second);
            thread2.Start();
            bool val2 = false;
            void Second()
            {
                val2 = app.Start();
                app.Stop();
            }
            var expected = false;
            var actual = val2;
            Assert.AreEqual(expected, actual);
        }
    }
}
