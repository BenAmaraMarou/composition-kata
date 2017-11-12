
namespace Restaurant
{
    public class Accounting : IAccounting
    {
        public bool Check(Meal meal, decimal money)
        {
            return meal.Price <= money;
        }
    }
}