namespace Restaurant
{
    public interface IClient
    {
        Dish Order(Menu menu);
        void Eat(Dish dish);
        bool Pay(Dish dish, decimal money);
    }
}