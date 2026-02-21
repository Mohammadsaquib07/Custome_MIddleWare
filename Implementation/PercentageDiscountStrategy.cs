using domain.discountstrategyinterface;

namespace PercentageDiscountStrategyImplementation
{
    public class PercentageDiscountStrategy :IDiscountStrategy
    {
        private readonly decimal discountStrategyAmount;

        public PercentageDiscountStrategy(decimal amount)
        {
            discountStrategyAmount = amount;
        }
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * discountStrategyAmount/100);
        }
    }
}