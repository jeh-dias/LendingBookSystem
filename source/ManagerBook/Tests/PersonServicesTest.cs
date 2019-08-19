using Domain;
using ManagerBooks.Repository.Interfaces;
using ManagerBooks.Services;
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
            var repository = new Mock<IPersonRepository>();
            var services = new PersonServices(repository.Object);
            var personResult = repository.Setup(x => x.Insert(It.IsAny<Person>()));

            Assert.NotNull(personResult);
        }

        [Fact(DisplayName = "GetAll success")]
        public void PersonServiceGetAll()
        {
            var repository = new Mock<IPersonRepository>();
            var services = new PersonServices(repository.Object);
            var personResult = repository.Setup(x => x.GetAll());

            Assert.NotNull(personResult);
        }

        [Fact(DisplayName = "GetByKey success")]
        public void PersonServiceGetByKey()
        {
            var repository = new Mock<IPersonRepository>();
            var services = new PersonServices(repository.Object);
            var personKey = repository.Setup(x => x.GetByKey(It.IsAny<Guid>()));

            Assert.NotNull(personKey);
        }

        [Fact(DisplayName = "Update success")]
        public void PersonServiceUpdate()
        {
            var repository = new Mock<IPersonRepository>();
            var services = new PersonServices(repository.Object);
            var personUpdated = repository.Setup(x => x.Update(It.IsAny<Person>()));

            Assert.NotNull(personUpdated);
        }

        [Fact(DisplayName = "Delete success")]
        public void PersonServiceDelete()
        {
            var repository = new Mock<IPersonRepository>();
            var services = new PersonServices(repository.Object);
            var result = repository.Setup(x => x.Delete(It.IsAny<Person>()));

            Assert.NotNull(result.Equals(true));
        }
    }
}
