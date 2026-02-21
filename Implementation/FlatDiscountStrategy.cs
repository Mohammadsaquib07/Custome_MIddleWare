using domain.discountstrategyinterface;

namespace FlatDiscountStrategyImplementation
{
    public class FlatDiscountStrategy :IDiscountStrategy
    {
        private readonly decimal flatDiscountAmount;

        public FlatDiscountStrategy(decimal flatDiscount)
        {
            flatDiscountAmount = flatDiscount;
        }
        
        public decimal ApplyDiscount(decimal amount)
        {
            return amount - flatDiscountAmount;
        }

    }
}