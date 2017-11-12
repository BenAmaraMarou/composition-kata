namespace Restaurant
{
    public class Customer : ICustomer
    {
        private IWaiter waiter;

        public Customer(IWaiter waiter)
        {
            this.waiter = waiter;
        }

        public Meal Order(Menu menu)
        {
            return waiter.Serve(menu);
        }

        public void Eat(Meal meal)
        {
            meal.Consumed = true;
        }

        public bool Pay(Meal meal, decimal money)
        {
            var paymentOk = waiter.Cash(meal, money);
            return paymentOk;
        }
    }
}
