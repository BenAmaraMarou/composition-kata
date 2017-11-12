using Composition.Restaurant;

namespace Composition.Restaurant
{
    public interface Cook
    {
        Meal Prepare(Menu menu);
    }
}