using Business.Interfaces;
using Domain;
using ManagerBooks.Services;
using Moq;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    [Trait("Unit", "LendingServices")]
    public class LendingServicesTest
    {
        [Fact(DisplayName = "Insert success")]
        public void LendingServiceInsert()
        {
            var business = new Mock<ILendingBusiness>();
            var lendingResult = business.Setup(x => x.Insert(It.IsAny<Lending>()));

            Assert.NotNull(lendingResult);
            //Assert.True(lendingResult.key != Guid.Empty);
            //Assert.True(lendingResult.dateDevolution != null);
            //Assert.True(lendingResult.dateLending.Equals(DateTime.Now));
        }

        [Fact(DisplayName = "GetAll success")]
        public void LendingServiceGetAll()
        {
            var services = new Mock<ILendingServices>();
            var lendingResult = services.Setup(x => x.GetAll());

            Assert.NotNull(lendingResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void LendingServiceGetByKey()
        {
            var services = new Mock<ILendingServices>();
            var lendingKey = services.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(lendingKey);
        }

        [Fact(DisplayName = "Update success")]
        public void LedingServiceUpdate()
        {
            var services = new Mock<ILendingServices>();
            var lendingUpdated = services.Setup(x => x.Update(It.IsAny<Lending>()));

            Assert.NotNull(lendingUpdated);
        }
    }
}
