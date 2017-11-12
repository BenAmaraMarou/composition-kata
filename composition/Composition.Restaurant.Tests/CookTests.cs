using NUnit.Framework;

namespace Composition.Restaurant.Tests.old
{
    public class CookTests
    {
        [Test]
        public void Cook_Prepares_Meal()
        {
            Chef cook = new Chef();
            Meal meal = cook.Prepare(Menu.Spaghetti);
            Assert.IsNotNull(meal);
        }
    }
}
