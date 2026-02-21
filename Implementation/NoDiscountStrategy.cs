using domain.discountstrategyinterface;

namespace NoDiscountStrategyImplementation
{
    public class NoDiscountStrategy:IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount;
        }
    }
}