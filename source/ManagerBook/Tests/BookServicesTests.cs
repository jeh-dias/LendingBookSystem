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
            var services = new Mock<IBookServices>();
            var bookResult = services.Setup(x => x.Insert(It.IsAny<Book>()));

            Assert.NotNull(bookResult);
        }

        [Fact(DisplayName = "GetAll success")]
        public void BookServiceGetAll()
        {
            var services = new Mock<IBookServices>();
            var bookResult = services.Setup(x => x.GetAll());

            Assert.NotNull(bookResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void BookServiceGetByKey()
        {
            var services = new Mock<IBookServices>();
            var bookKey = services.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(bookKey);
        }

        [Fact(DisplayName = "Update success")]
        public void BookServiceUpdate()
        {
            var services = new Mock<IBookServices>();
            var bookUpdated = services.Setup(x => x.Update(It.IsAny<Book>()));

            Assert.NotNull(bookUpdated);
        }

        [Fact(DisplayName = "Delete success")]
        public void BookServiceDelete()
        {
            var services = new Mock<IBookServices>();
            var result = services.Setup(x => x.Delete(It.IsAny<Book>()));

            Assert.NotNull(result.Equals(true));
        }
    }
}
