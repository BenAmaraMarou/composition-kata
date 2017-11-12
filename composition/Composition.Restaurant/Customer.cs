using Composition.Restaurant;

namespace Composition.Restaurant
{
    // Client: creates a command and set the receiver of the command
    public class Customer
    {
        private readonly Cook _cook;

        public Customer()
        {
            _cook = new Chef();
        }

        public Meal OrderSpaghetti()
        {
            MealCommand command = new SpaghettiCommand(_cook);
            Waiter waiter = new Waiter(command);
            Meal spaghetti = waiter.TakeCommand(Menu.Spaghetti);
            return spaghetti;
        }
    }
}
