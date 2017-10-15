using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class CookTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private readonly Dish _spaghettiDish = new Dish(Spaghetti, SpaghettiPrice);
        private Cook _cook;

        [SetUp]
        public void SetUp()
        {
            _cook = new Cook();
        }

        [Test]
        public void Cook_Should_Cook_Dish()
        {
            var actualDish = _cook.Prepare(Spaghetti);
            Assert.AreEqual(_spaghettiDish, actualDish);
        }
    }
}
