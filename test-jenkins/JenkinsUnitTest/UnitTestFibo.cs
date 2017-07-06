using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_jenkins;

namespace JenkinsUnitTest
{
    [TestClass]
    public class UnitTestFibo
    {
        [TestMethod]
        public void TestGenerator()
        {
            Assert.IsNotNull(Fibonacci.Generate(5));
        }
    }
}
