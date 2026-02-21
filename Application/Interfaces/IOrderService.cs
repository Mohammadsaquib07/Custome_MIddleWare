using domain.orderentity;
using domain.discountstrategyinterface;

namespace OrderServiceInterface
{
    public interface IOrderService
    {
        Order CreateOrder(int orderId);
        void AddItems(Order order,string name,decimal price,int quantity);
        decimal GetTotal(Order order, IDiscountStrategy discountStrategy);
        decimal GetDiscountApplied(Order order, IDiscountStrategy discountStrategy);
    }
}