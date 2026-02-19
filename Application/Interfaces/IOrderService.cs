using domain.orderentity;

namespace OrderServiceInterface
{
    public interface IOrderService
    {
        Order CreateOrder(int orderId);
        void AddItems(Order order,string name,decimal price,int quantity);
        decimal GetTotal(Order order);
    }
}