using Business;
using Domain;
using FakeItEasy;
using Moq;
using Repository.Interfaces;
using Xunit;

namespace Tests
{
    [Trait("Unit", "Lending Business")]
    public class BookServices
    {
        [Fact(DisplayName = "Insert success")]
        public void InsertSuccess()
        {
            var lendingRepository = new Mock<ILendingRepository>();
            var lendingBusiness = new LendingBusiness(lendingRepository.Object);
            var lending = A.Fake<Lending>();
            lendingRepository.Setup(x => x.Insert(It.IsAny<Lending>())).Returns(lending);
            var result = lendingBusiness.Insert(lending);

            Assert.NotNull(result);
            Assert.True(result.id > 0);
        }
    }
}
