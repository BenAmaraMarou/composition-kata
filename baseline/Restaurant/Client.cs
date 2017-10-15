namespace Restaurant
{
    public class Client : IClient
    {
        private IWaiter waiter;

        public Client(IWaiter waiter)
        {
            this.waiter = waiter;
        }

        public Dish Order(Menu menu)
        {
            return waiter.Serve(menu);
        }

        public void Eat(Dish dish)
        {
            dish.Consumed = true;
        }

        public bool Pay(Dish dish, decimal money)
        {
            var paymentOk = waiter.Cash(dish, money);
            return paymentOk;
        }
    }
}
