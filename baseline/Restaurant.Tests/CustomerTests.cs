using NSubstitute;
using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class CustomerTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private readonly Meal _spaghettiMeal = new Meal(Spaghetti, SpaghettiPrice);
        private const bool isPaymentDone = true;
        private IWaiter _waiter;
        private Customer _customer;

        [SetUp]
        public void SetUp()
        {
            _waiter = Substitute.For<IWaiter>();
            _customer = new Customer(_waiter);
        }

        [Test]
        public void Customer_Orders_Spaghetti()
        {
            _waiter.Serve(Spaghetti).Returns(_spaghettiMeal);
            var actual = _customer.Order(Menu.Spaghetti);
            Assert.AreEqual(_spaghettiMeal, actual);
        }

        [Test]
        public void Customer_Eats_Spaghetti()
        {
            _customer.Eat(_spaghettiMeal);
            Assert.IsTrue(_spaghettiMeal.Consumed);
        }

        [Test]
        public void Customer_Pays_For_Meal()
        {
            _waiter.Cash(_spaghettiMeal, SpaghettiPrice).Returns(CustomerTests.isPaymentDone);
            var isPaymentDone = _customer.Pay(_spaghettiMeal, SpaghettiPrice);
            _waiter.Received().Cash(_spaghettiMeal, SpaghettiPrice);
            Assert.IsTrue(isPaymentDone);
        }
    }
}
