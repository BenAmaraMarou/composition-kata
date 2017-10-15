namespace Restaurant
{
    public interface IWaiter
    {
        Dish Serve(Menu menu);
        bool Cash(Dish dish, decimal money);
    }
}