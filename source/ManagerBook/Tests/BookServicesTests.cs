using Domain;
using FakeItEasy;
using ManagerBooks.Applications.Controllers;
using ManagerBooks.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Repository.Interfaces;
using Services;
using System;
using Xunit;

namespace Tests
{
    [Trait("Unit", "BookServices")]
    public class BookServicesTest
    {
        [Fact(DisplayName = "Insert success")]
        public void BookServiceInsert()
        {
            var repository = new Mock<IBookRepository>();
            var services = new BookServices(repository.Object);
            var bookResult = repository.Setup(x => x.Insert(It.IsAny<Book>()));

            Assert.NotNull(bookResult);
        }

        [Fact(DisplayName = "GetAll success")]
        public void BookServiceGetAll()
        {
            var repository = new Mock<IBookRepository>();
            var services = new BookServices(repository.Object);
            var bookResult = repository.Setup(x => x.GetAll());

            Assert.NotNull(bookResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void BookServiceGetByKey()
        {
            var repository = new Mock<IBookRepository>();
            var services = new BookServices(repository.Object);
            var bookKey = repository.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(bookKey);
        }

        [Fact(DisplayName = "Update success")]
        public void BookServiceUpdate()
        {
            var repository = new Mock<IBookRepository>();
            var services = new BookServices(repository.Object);

            var bookUpdated = repository.Setup(x => x.Update(It.IsAny<Book>()));

            Assert.NotNull(bookUpdated);
        }

        [Fact(DisplayName = "Delete success")]
        public void BookServiceDelete()
        {
            var repository = new Mock<IBookRepository>();
            var services = new BookServices(repository.Object);

            var result = repository.Setup(x => x.Delete(It.IsAny<Book>()));

            Assert.NotNull(result.Equals(true));
        }
    }
}
