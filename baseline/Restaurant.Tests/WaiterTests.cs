using NSubstitute;
using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class WaiterTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private const decimal LessThanSpaghettiPrice = 9;
        private readonly Dish _spaghettiDish = new Dish(Spaghetti, SpaghettiPrice);
        private const bool ValidPayment = true;
        private const bool UnvalidPayment = false;
        private Waiter _waiter;
        private ICook _cook;
        private IAccounting _accounting;

        [SetUp]
        public void SetUp()
        {
            _cook = Substitute.For<ICook>();
            _accounting = Substitute.For<IAccounting>();
            _waiter = new Waiter(_cook, _accounting);
        }

        [Test]
        public void Waiter_Should_Serve_Dish()
        {
            _cook.Prepare(Spaghetti).Returns(_spaghettiDish);
            var actualDish = _waiter.Serve(Spaghetti);
            Assert.AreEqual(_spaghettiDish, actualDish);
            _cook.Received().Prepare(Spaghetti);
        }

        [Test]
        public void Waiter_Should_Cash_Payment_Of_Dish()
        {
            _accounting.Check(_spaghettiDish, SpaghettiPrice).Returns(ValidPayment);
            var isPaymentDone = _waiter.Cash(_spaghettiDish, SpaghettiPrice);
            Assert.IsTrue(isPaymentDone);
            _accounting.Received().Check(_spaghettiDish, SpaghettiPrice);
        }

        [Test]
        public void Waiter_Should_Refuse_Cash_If_Payment_Is_Not_Enough()
        {
            _accounting.Check(_spaghettiDish, SpaghettiPrice).Returns(UnvalidPayment);
            var isPaymentDone = _waiter.Cash(_spaghettiDish, SpaghettiPrice);
            Assert.IsFalse(isPaymentDone);
        }
    }
}
