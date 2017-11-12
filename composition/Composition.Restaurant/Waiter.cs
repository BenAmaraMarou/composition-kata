using Composition.Restaurant;

namespace Composition.Restaurant
{
    //Invoker : holds command and make it execute (but does not do the actual operation)
    public class Waiter
    {
        private readonly MealCommand _command;

        public Waiter(MealCommand command)
        {
            _command = command;
        }

        public Meal TakeCommand(Menu menu)
        {
            return _command.Execute(menu);
        }
    }
}