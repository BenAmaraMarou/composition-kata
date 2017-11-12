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
        private readonly Meal _spaghettiMeal = new Meal(Spaghetti, SpaghettiPrice);
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
        public void Waiter_Should_Serve_Meal()
        {
            _cook.Prepare(Spaghetti).Returns(_spaghettiMeal);
            var actualMeal = _waiter.Serve(Spaghetti);
            Assert.AreEqual(_spaghettiMeal, actualMeal);
            _cook.Received().Prepare(Spaghetti);
        }

        [Test]
        public void Waiter_Should_Cash_Payment_Of_Meal()
        {
            _accounting.Check(_spaghettiMeal, SpaghettiPrice).Returns(ValidPayment);
            var isPaymentDone = _waiter.Cash(_spaghettiMeal, SpaghettiPrice);
            Assert.IsTrue(isPaymentDone);
            _accounting.Received().Check(_spaghettiMeal, SpaghettiPrice);
        }

        [Test]
        public void Waiter_Should_Refuse_Cash_If_Payment_Is_Not_Enough()
        {
            _accounting.Check(_spaghettiMeal, SpaghettiPrice).Returns(UnvalidPayment);
            var isPaymentDone = _waiter.Cash(_spaghettiMeal, SpaghettiPrice);
            Assert.IsFalse(isPaymentDone);
        }
    }
}
