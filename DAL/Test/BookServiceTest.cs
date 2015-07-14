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
        private static Book _book = new Book
                {
                    Categories = new List<Category>(),
                    Title = "Book 1",
                    Author = "AAA",
                    Rating = 3,
                    Amount = 3
                };

        private static readonly Mock<DbSet<Book>> DbSet = new Mock<DbSet<Book>>();


        [TestInitialize]
        public void Init()
        {
            IoC.Container.Configure(cfg =>
            {
                cfg.For<IDbContext>().Use<LibraryContext>();
                cfg.For<IUnitOfWork>().Use<UnitOfWork>();
            });
        }

        [TestMethod]
        public void Repository_Insert_ShouldBe_Called()
        {
         
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(DbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);
            repoMock.Setup(r => r.Insert(It.IsAny<Book>()));

            var bookService = new BookService(mockUnitOfWork.Object);

            bookService.InsertBook(_book);

            repoMock.VerifyAll();
        }




        [TestMethod]
        public void UnitOfWork_Save_ShouldBe_Called()
        {
          //  var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(DbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);
            mockUnitOfWork.Setup(u => u.Save());

            var bookService = new BookService(mockUnitOfWork.Object);

            bookService.InsertBook(new Book());

            mockUnitOfWork.VerifyAll();
        }

        [TestMethod]
        public void Repository_Insert_ShouldBe_Called_With_Right_Argument()
        {

            var book = new Book();

            //var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(DbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);
            repoMock.Setup(r => r.Insert(It.IsAny<Book>())).Callback<Book>( b => { book = b; });

            var bookService = new BookService(mockUnitOfWork.Object);

            bookService.InsertBook(_book);

            Assert.AreEqual(_book.Title, book.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullException_ShouldBe_Throw_When_Passing_NullArgument()
        {
            //var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(DbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);

            var bookService = new BookService(mockUnitOfWork.Object);

            bookService.InsertBook(null);

        }

        [TestMethod]
        public void Notification_ShouldBe_Send_When_Added_New_Book()
        {
            //var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(DbSet.Object);
            var repoMock = new Mock<IRepository<Book>>();

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(u => u.Repository<Book>()).Returns(repoMock.Object);
          //  var bookService = new BookService(mockUnitOfWork.Object);

            var service = new Mock<BookService>(mockUnitOfWork.Object);
            service.Setup(s => s.NotifiNewBooks(It.IsAny<Book>()));

           // service.Object.InsertBook(new Book());
            service.Verify();

        }

        [TestMethod]
        public void ReceivedDate_ShouldBe_Set_When_Insert_A_Book()
        {
            //var dbSet = new Mock<DbSet<Book>>();
            var context = new Mock<LibraryContext>();
            context.Setup(s => s.Set<Book>()).Returns(DbSet.Object);
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
