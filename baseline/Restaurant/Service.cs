namespace Restaurant
{
    public class Service
    {
        private ICustomer customer;

        public Service(ICustomer customer)
        {
            this.customer = customer;
        }

        public bool Make(Menu menu, decimal money)
        {
            var meal = customer.Order(menu);
            customer.Eat(meal);
            var isPaymentDone = customer.Pay(meal, money);
            return isPaymentDone;
        }
    }
}