namespace Restaurant
{
    public class Service
    {
        private IClient client;

        public Service(IClient client)
        {
            this.client = client;
        }

        public bool Make(Menu menu, decimal money)
        {
            var dish = client.Order(menu);
            client.Eat(dish);
            var isPaymentDone = client.Pay(dish, money);
            return isPaymentDone;
        }
    }
}