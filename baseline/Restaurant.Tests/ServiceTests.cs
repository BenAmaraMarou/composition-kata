using NSubstitute;
using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class ServiceTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private readonly Dish _spaghettiDish = new Dish(Spaghetti, SpaghettiPrice);
        private const bool IsPaymentDone = true;
        private IClient client;

        [SetUp]
        public void SetUp()
        {
            client = Substitute.For<IClient>();
        }
        
        [Test]
        public void Servcice_Should_Be_Made_For_Client()
        {
            //Arrange
            client.Order(Spaghetti).Returns(_spaghettiDish);
            client.Pay(_spaghettiDish, SpaghettiPrice).Returns(IsPaymentDone);
            var service = new Service(client);
            //Act
            var isServiceDone = service.Make(Spaghetti, SpaghettiPrice);
            //Assert
            client.Received().Order(Spaghetti);
            client.Received().Pay(_spaghettiDish, SpaghettiPrice);
            Assert.IsTrue(isServiceDone);
        }
    }
}
