using Composition.Restaurant;

namespace Composition.Restaurant
{
    // Concrete Command contains who can execute it
    public class SpaghettiCommand : MealCommand
    {
        private readonly Cook _cook;

        public SpaghettiCommand(Cook cook)
        {
            _cook = cook;
        }

        public Meal Execute(Menu menu)
        {
            return _cook.Prepare(menu);
        }
    }
}