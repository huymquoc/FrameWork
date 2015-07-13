using System;
using System.Collections.Generic;
using System.Data.Entity;
using Framework.Repository;
using Framework.Web;
using Framework.Web.Domain;
using Framework.Web.FrameworkFactory;
using Framework.Web.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StructureMap;

namespace Test
{
    [TestClass]
    public class BookServiceTest
    {
        [TestInitialize]
        public void Init()
        {
            IoC.Container.Configure(cfg =>
            {
                cfg.For<IDbContext>().Use<LibraryContext>();
                cfg.For<IUnitOfWork>().Use<UnitOfWork>();
            });
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var dbSet = new Mock<DbSet<Book>>();
        //    var context = new Mock<LibraryContext>();
        //    context.Setup(s => s.Set<Book>()).Returns(dbSet.Object);
        //    var repo = new Repository<Book>(context.Object);

        //    var student = context.Object.Set<Book>().Find(1);
        //    var a = repo.FindById(1);
        //    Assert.Equals(student.BookID, 1);
        //}

        [TestMethod]
        public void Repository_Insert_And_Save_ShouldBe_Called()
        {
            var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(dbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);

            var bookService = new BookService(mockUnitOfWork.Object);

            bookService.InsertBook(new Book
            {
                Categories = new List<Category>(),
                Title = "Book 1",
                Author = "AAA",
                Rating = 3,
                Amount = 3
            });

            repoMock.VerifyAll();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullException_ShouldBe_Throw_When_Passing_NullArgument()
        {
            var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(dbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);

            var bookService = new BookService(mockUnitOfWork.Object);

            bookService.InsertBook(null);

        }

        [TestMethod]
        public void ReceivedDate_ShouldBe_Set_When_Insert_A_Book()
        {
            var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(dbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();
           // repoMock.Setup(r => r.Insert(It.IsAny<Book>()));

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);

            var bookService = new BookService(mockUnitOfWork.Object);
            var book = new Mock<Book>();
            
            bookService.InsertBook(book.Object);
            // book.VerifySet(x => x.ReceivedDate = DateTime.Now);
            
            //repoMock.Verify(x => x.Insert(It.Is<Book>(b=>b.ReceivedDate == DateTime.Now)));
        }


    }
}
