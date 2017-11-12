using NUnit.Framework;

namespace Restaurant.Tests
{
    [Category("baseline")]
    public class CookTests
    {
        private const Menu Spaghetti = Menu.Spaghetti;
        private const decimal SpaghettiPrice = 10;
        private readonly Meal _spaghettiMeal = new Meal(Spaghetti, SpaghettiPrice);
        private Cook _cook;

        [SetUp]
        public void SetUp()
        {
            _cook = new Cook();
        }

        [Test]
        public void Cook_Prepares_Meal()
        {
            var actualMeal = _cook.Prepare(Spaghetti);
            Assert.AreEqual(_spaghettiMeal, actualMeal);
        }
    }
}
