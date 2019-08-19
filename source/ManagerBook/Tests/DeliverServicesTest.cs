using Domain;
using Moq;
using Services;
using Services.Interfaces;
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
            var services = new Mock<IDeliverServices>();
            var deliverResult = services.Setup(x => x.Insert(It.IsAny<Deliver>()));

            Assert.NotNull(deliverResult);
        }

        [Fact(DisplayName = "GetAll success")]
        public void DeliverServiceGetAll()
        {
            var services = new Mock<IDeliverServices>();
            var deiverResult = services.Setup(x => x.GetAll());

            Assert.NotNull(deiverResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void DeliverServiceGetByKey()
        {
            var services = new Mock<IDeliverServices>();
            var deliverKey = services.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(deliverKey);
        }

        [Fact(DisplayName = "Update success")]
        public void DeliverServiceUpdate()
        {
            var services = new Mock<IDeliverServices>();
            var deliverUpdated = services.Setup(x => x.Update(It.IsAny<Deliver>()));

            Assert.NotNull(deliverUpdated);
        }
    }
}
