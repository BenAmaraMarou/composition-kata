using Composition.Restaurant;

namespace Composition.Restaurant
{
    public class Meal
    {
        private readonly Menu _menu;

        public Meal(Menu menu)
        {
            _menu = menu;
        }
    }
}