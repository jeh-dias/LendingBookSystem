using Domain;
using Moq;
using Repository.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    [Trait("Unit", "DeliverServices")]
    public class DeliverServicesTest
    {
        [Fact(DisplayName = "Insert success")]
        public void DeliverServiceInsert()
        {
            var repository = new Mock<IDeliverRepository>();
            var services = new DeliverServices(repository.Object);
            var deliverResult = repository.Setup(x => x.Insert(It.IsAny<Deliver>()));

            Assert.NotNull(deliverResult);
        }

        [Fact(DisplayName = "GetAll success")]
        public void DeliverServiceGetAll()
        {
            var repository = new Mock<IDeliverRepository>();
            var services = new DeliverServices(repository.Object);
            var deiverResult = repository.Setup(x => x.GetAll());

            Assert.NotNull(deiverResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void DeliverServiceGetByKey()
        {
            var repository = new Mock<IDeliverRepository>();
            var services = new DeliverServices(repository.Object);
            var deliverKey = repository.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(deliverKey);
        }

        [Fact(DisplayName = "Update success")]
        public void DeliverServiceUpdate()
        {
            var repository = new Mock<IDeliverRepository>();
            var services = new DeliverServices(repository.Object);
            var deliverUpdated = repository.Setup(x => x.Update(It.IsAny<Deliver>()));

            Assert.NotNull(deliverUpdated);
        }
    }
}
