using Domain;
using FakeItEasy;
using ManagerBooks.Applications.Controllers;
using ManagerBooks.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace ManagerBooksTests
{
    public class BookControllerTest
    {
        [Fact(DisplayName = "Insert success")]
        public void InsertSuccess()
        {
            var bookServices = new Mock<IBookServices>();
            var logger = new Mock<ILogger<BookController>>();
            var bookController = new BookController(bookServices.Object, logger);

            //bookServices
            //    .Setup(x => x.Insert(It.IsAny<Book>()))
            //    .Returns(OkObjectResult);

            //var bookEntity = A.New<Book>();

            //var response = shoppingCartsController.Post(shoppingCartsViewModel);

            //Assert.NotNull(response);
            //Assert.IsType<OkObjectResult>(response.Result);

            //var httpObjResult = response.Result as OkObjectResult;

            //Assert.NotNull(httpObjResult);
            //Assert.True(httpObjResult.StatusCode == 200);

            //var value = httpObjResult.Value;

            //Assert.NotNull(value);
            //Assert.False(string.IsNullOrWhiteSpace(value.ToString()));
            //Assert.Same("Success", value);
        }
    }
}
