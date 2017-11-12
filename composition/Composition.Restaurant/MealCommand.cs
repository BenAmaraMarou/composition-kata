using Composition.Restaurant;

namespace Composition.Restaurant
{
    //Command: asks receiver to do the necessary operation
    public interface MealCommand
    {
        Meal Execute(Menu menu);
    }
}