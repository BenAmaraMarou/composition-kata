using NSubstitute;
using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class ServiceTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private readonly Meal _spaghettiMeal = new Meal(Spaghetti, SpaghettiPrice);
        private const bool IsPaymentDone = true;
        private ICustomer customer;

        [SetUp]
        public void SetUp()
        {
            customer = Substitute.For<ICustomer>();
        }
        
        [Test]
        public void Servcice_Should_Be_Made_For_Customer()
        {
            customer.Order(Spaghetti).Returns(_spaghettiMeal);
            customer.Pay(_spaghettiMeal, SpaghettiPrice).Returns(IsPaymentDone);
            var service = new Service(customer);
            var isServiceDone = service.Make(Spaghetti, SpaghettiPrice);
            customer.Received().Order(Spaghetti);
            customer.Received().Pay(_spaghettiMeal, SpaghettiPrice);
            Assert.IsTrue(isServiceDone);
        }
    }
}
