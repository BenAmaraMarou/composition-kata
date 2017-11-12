
namespace Restaurant
{
    public class Meal
    {
        private Menu menu;
        public bool Consumed { get; set; }
        public decimal Price { get; private set; }

        public Meal(Menu menu, decimal price)
        {
            this.menu = menu;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            var meal = obj as Meal;
            if (meal == null)
            {
                return false;
            }
            return meal.menu == menu && meal.Price == Price;
        }

        public override int GetHashCode()
        {
            return menu.GetHashCode();
        }
    }
}