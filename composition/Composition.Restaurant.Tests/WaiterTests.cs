using NSubstitute;
using NUnit.Framework;
using Composition.Restaurant;

namespace Composition.Restaurant.Tests
{
    public class WaiterTests
    {

        [Test]
        public void Should_execute_command()
        {
            var spaghetti = Menu.Spaghetti;
            var command = Substitute.For<MealCommand>();
            command
                .Execute(spaghetti)
                .Returns(new Meal(spaghetti));
            var waiter = new Waiter(command);

            var meal = waiter.TakeCommand(spaghetti);

            command.Received().Execute(spaghetti);
            Assert.IsNotNull(meal);

        }
    }
}
