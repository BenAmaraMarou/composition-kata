using NSubstitute;
using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class ClientTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private readonly Dish _spaghettiDish = new Dish(Spaghetti, SpaghettiPrice);
        private const bool isPaymentDone = true;
        private IWaiter _waiter;
        private Client _client;

        [SetUp]
        public void SetUp()
        {
            _waiter = Substitute.For<IWaiter>();
            _client = new Client(_waiter);
        }

        [Test]
        public void Client_Should_Order_Spaghetti()
        {
            _waiter.Serve(Spaghetti).Returns(_spaghettiDish);
            var actual = _client.Order(Menu.Spaghetti);
            Assert.AreEqual(_spaghettiDish, actual);
        }

        [Test]
        public void Client_Should_Eat_Spaghetti()
        {
            _client.Eat(_spaghettiDish);
            Assert.IsTrue(_spaghettiDish.Consumed);
        }

        [Test]
        public void Client_Should_Pay_For_Dish()
        {
            _waiter.Cash(_spaghettiDish, SpaghettiPrice).Returns(ClientTests.isPaymentDone);
            var isPaymentDone = _client.Pay(_spaghettiDish, SpaghettiPrice);
            _waiter.Received().Cash(_spaghettiDish, SpaghettiPrice);
            Assert.IsTrue(isPaymentDone);
        }
    }
}
