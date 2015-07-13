using System.Data.Entity;
using Framework.Web.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dbSet = new Mock<DbSet<Student>>();
            var context = new Mock<SchoolContext>();
            context.Setup(s => s.Set<Student>()).Returns(dbSet.Object);
            var student = context.Object.Set<Student>().Find(1);
            Assert.Equals(student.PersonID, 1);
        }


    }
}
