using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Cook : ICook
    {
        private readonly IDictionary<Menu, decimal> _pricing = new Dictionary<Menu, decimal> { { Menu.Spaghetti, 10 }};

        public Dish Prepare(Menu menu)
        {
            var dish = _pricing.Single(item => item.Key == menu);
            return new Dish(menu, dish.Value);
        }
    }
}