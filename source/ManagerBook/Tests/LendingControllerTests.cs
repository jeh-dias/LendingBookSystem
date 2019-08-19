using Domain;
using FakeItEasy;
using ManagerBooks.Applications.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    [Trait("Unit", "Lending")]
    public class LendingControllerTests
    {
        [Fact(DisplayName = "Insert success")]
        public void InsertSuccess()
        {
            var lendingServices = new Mock<ILendingServices>();
            var logger = new Mock<ILogger<LendingController>>();
            var lendingController = new LendingController(lendingServices.Object, logger.Object);
            var lending = A.Fake<Lending>();

            lendingServices.Setup(x => x.Insert(It.IsAny<Lending>())).Returns(lending);

            var response = lendingController.Insert(lending);
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response.Result);

            var httpObjResult = response.Result as OkObjectResult;

            Assert.NotNull(httpObjResult);
            Assert.True(httpObjResult.StatusCode == 200);

            var value = httpObjResult.Value;

            Assert.NotNull(value);
            Assert.False(string.IsNullOrWhiteSpace(value.ToString()));
            Assert.Same("success", value);
        }
    }
}
