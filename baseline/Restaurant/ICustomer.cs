namespace Restaurant
{
    public interface ICustomer
    {
        Meal Order(Menu menu);
        void Eat(Meal meal);
        bool Pay(Meal meal, decimal money);
    }
}