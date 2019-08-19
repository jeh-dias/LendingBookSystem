using Domain;
using ManagerBooks.Services.Interfaces;
using Moq;
using Repository.Interfaces;
using System;
using Xunit;

namespace ManagaerBooksTests
{
        public class BookServicesTest
        {
            [Fact]
            public void BookServicesTestSucess()
            {
                var bookRepository = new Mock<IBookRepository>();
                var bookServicesMock = new Mock<IBookServices>(bookRepository.Object);
                var bookEntity = new Book();

               var bookResultServices = bookServicesMock.Setup(
                    a => a.Insert(It.IsAny<Book>())).Returns(bookEntity);

                var bookResultRepository = bookRepository.Setup(x => x.Insert(It.IsAny<Book>())).Returns(bookEntity);

                Assert.NotNull(bookEntity);
                Assert.NotNull(bookResultServices);
                Assert.NotNull(bookResultRepository);
            //Assert.False(bookEntity.key.Equals(string.Empty));
        }
        }
}
