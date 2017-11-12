using Composition.Restaurant;
using NSubstitute;
using NUnit.Framework;

namespace Composition.Restaurant.Tests
{
    public class CustomerTests
    {
        [Test]
        public void Should_order_spaghetti()
        {
            var customer = new Customer();
            var dish = customer.OrderSpaghetti();
            Assert.IsNotNull(dish);
        }
    }
}
