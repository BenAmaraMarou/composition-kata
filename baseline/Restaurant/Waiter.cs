namespace Restaurant
{
    public class Waiter : IWaiter
    {
        private readonly ICook _cook;
        private readonly IAccounting _accounting;

        public Waiter(ICook cook, IAccounting accounting)
        {
            _cook = cook;
            _accounting = accounting;
        }

        public bool Cash(Meal meal, decimal money)
        {
            return _accounting.Check(meal, money);
        }

        public Meal Serve(Menu menu)
        {
            return _cook.Prepare(menu);
        }
    }
}