using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Cook : ICook
    {
        private readonly IDictionary<Menu, decimal> _pricing = new Dictionary<Menu, decimal> { { Menu.Spaghetti, 10 }};

        public Meal Prepare(Menu menu)
        {
            var meal = _pricing.Single(item => item.Key == menu);
            return new Meal(menu, meal.Value);
        }
    }
}