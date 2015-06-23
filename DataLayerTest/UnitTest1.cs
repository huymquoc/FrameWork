using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace DataLayerTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            var i = 0;
            Assert.AreEqual(i,0);
        }
    }
}
