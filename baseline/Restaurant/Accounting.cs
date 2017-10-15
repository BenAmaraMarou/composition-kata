
namespace Restaurant
{
    public class Accounting : IAccounting
    {
        public bool Check(Dish dish, decimal money)
        {
            return dish.Price <= money;
        }
    }
}