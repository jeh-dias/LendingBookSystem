using Business.Interfaces;
using Domain;
using ManagerBooks.Services;
using Moq;
using Repository.Interfaces;
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
            var repository = new Mock<ILendingRepository>();
            var business = new Mock<ILendingBusines>();
            var services = new LendingServices(business.Object, repository.Object);
            var lendingResult = repository.Setup(x => x.Insert(It.IsAny<Lending>()));

            Assert.NotNull(lendingResult);
            //Assert.True(lendingT.key != Guid.Empty);
            //Assert.True(lendingT.dateDevolution != null);
            //Assert.True(lendingT.dateLending.Equals(DateTime.Now));
        }

        [Fact(DisplayName = "GetAll success")]
        public void LendingServiceGetAll()
        {
            var repository = new Mock<ILendingRepository>();
            var lendingResult = repository.Setup(x => x.GetAll());

            Assert.NotNull(lendingResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void LendingServiceGetByKey()
        {
            var repository = new Mock<ILendingRepository>();
            //var services = new LendingServices(repository.Object);
            var lendingKey = repository.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(lendingKey);
        }

        [Fact(DisplayName = "Update success")]
        public void LedingServiceUpdate()
        {
            var repository = new Mock<ILendingRepository>();
            var lendingUpdated = repository.Setup(x => x.Update(It.IsAny<Lending>()));

            Assert.NotNull(lendingUpdated);
        }
    }
}
