using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerProblems;

namespace ProjectEulerTesting
{
    /* Testing cases for the current projects I'm working on will be uncommented.*/
    [TestClass]
    public class UnitTest1
    {
        /* These methods were used to make sure the Fibonacci sequence was working correctly.*/
        [TestMethod]
        public void TestMethod1()
        {
            var testResult = Problem2.Fib(1);
            Assert.AreEqual(1, testResult, "This doesn't return 1.");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var testResult = Problem2.Fib(2);
            Assert.AreEqual(1, testResult, "This doesn't return 1.");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var testResult = Problem2.Fib(7);
            Assert.AreEqual(13, testResult, "This doesn't return 13.");
        }
    }
}
