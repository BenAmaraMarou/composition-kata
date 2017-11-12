namespace Restaurant
{
    public interface IWaiter
    {
        Meal Serve(Menu menu);
        bool Cash(Meal meal, decimal money);
    }
}