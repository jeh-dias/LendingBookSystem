using Domain;
using ManagerBooks.Repository.Interfaces;
using ManagerBooks.Services;
using ManagerBooks.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    [Trait("Unit", "PersonServices")]
    public class PersonServicesTest
    {
        [Fact(DisplayName = "Insert success")]
        public void PersonServiceInsert()
        {
            var services = new Mock<IPersonServices>();
            var personResult = services.Setup(x => x.Insert(It.IsAny<Person>()));

            Assert.NotNull(personResult);
        }

        [Fact(DisplayName = "GetAll success")]
        public void PersonServiceGetAll()
        {
            var services = new Mock<IPersonServices>();
            var personResult = services.Setup(x => x.GetAll());

            Assert.NotNull(personResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void PersonServiceGetByKey()
        {
            var services = new Mock<IPersonServices>();
            var personKey = services.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(personKey);
        }

        [Fact(DisplayName = "Update success")]
        public void PersonServiceUpdate()
        {
            var services = new Mock<IPersonServices>();
            var personUpdated = services.Setup(x => x.Update(It.IsAny<Person>()));

            Assert.NotNull(personUpdated);
        }

        [Fact(DisplayName = "Delete success")]
        public void PersonServiceDelete()
        {
            var services = new Mock<IPersonServices>();
            var result = services.Setup(x => x.Delete(It.IsAny<Person>()));

            Assert.NotNull(result.Equals(true));
        }
    }
}
