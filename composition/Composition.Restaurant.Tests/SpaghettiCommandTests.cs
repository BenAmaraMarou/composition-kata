using NSubstitute;
using NUnit.Framework;

namespace Composition.Restaurant.Tests
{
    public class SpaghettiCommandTests
    {
        [Test]
        public void Should_get_spaghetti_prepared_by_cook()
        {
            var cook = Substitute.For<Cook>();
            cook.Prepare(Menu.Spaghetti).Returns(new Meal(Menu.Spaghetti));
            var command = new SpaghettiCommand(cook);

            var meal = command.Execute(Menu.Spaghetti);

            cook.Received().Prepare(Menu.Spaghetti);
            Assert.IsNotNull(meal);
        }
    }
}
