
namespace Restaurant
{
    public class Dish
    {
        private Menu menu;
        public bool Consumed { get; set; }
        public decimal Price { get; private set; }

        public Dish(Menu menu, decimal price)
        {
            this.menu = menu;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            var dish = obj as Dish;
            if (dish == null)
            {
                return false;
            }
            return dish.menu == menu && dish.Price == Price;
        }

        public override int GetHashCode()
        {
            return menu.GetHashCode();
        }
    }
}