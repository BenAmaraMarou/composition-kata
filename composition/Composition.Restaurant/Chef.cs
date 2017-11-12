using Composition.Restaurant;

namespace Composition.Restaurant
{
    //Receiver : knows how to do the operation
    public class Chef : Cook
    {
        public Meal Prepare(Menu menu)
        {
            return new Meal(menu);
        }
    }
}
