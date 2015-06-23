using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        private void TestMethod1()
        {
            Assert.Equals(0, 0);
        }

        [TestCase]
        private void TestMethod2()
        {
            var i = 1;
            Assert.Equals(i, 1);
        }

        [TestCase]
        private void TestMethod3()
        {
            var i = 1;
            Assert.Equals(i, 1);
        }
    }

    [TestFixture]
    public class Class2
    {
        [TestCase]
        private void TestMethod1()
        {
            Assert.Equals(0, 0);
        }

        [TestCase]
        private void TestMethod2()
        {
            var i = 1;
            Assert.Equals(i, 1);
        }

        [TestCase]
        private void TestMethod3()
        {
            var i = 1;
            Assert.Equals(i, 1);
        }
    }
}
