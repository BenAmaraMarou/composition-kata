using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class AccountingTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private const decimal LessThanSpaghettiPrice = 9;
        private readonly Dish _spaghettiDish = new Dish(Spaghetti, SpaghettiPrice);
        private Accounting _accounting;

        [SetUp]
        public void SetUp()
        {
            _accounting = new Accounting();
        }

        [Test]
        public void Accounting_Should_Accept_Payment_If_Money_Covers_Price()
        {
            var actualIsPayementAccepted = _accounting.Check(_spaghettiDish, SpaghettiPrice);
            Assert.IsTrue(actualIsPayementAccepted);
        }

        [Test]
        public void Waiter_Should_Refuse_Payment_If_Money_Is_Not_Enough()
        {
            var actualIsPayementAccepted = _accounting.Check(_spaghettiDish, LessThanSpaghettiPrice);
            Assert.IsFalse(actualIsPayementAccepted);
        }
    }
}
