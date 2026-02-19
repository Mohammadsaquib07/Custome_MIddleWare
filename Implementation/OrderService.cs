using domain.entities;
using domain.orderentity;
using OrderServiceInterface;

namespace OrderServiceImplementation
{
    public class OrderService : IOrderService
    {
        public Order CreateOrder(int orderId)
        {
            return new Order(orderId);
        }

        public void AddItems(Order order,string name,decimal price,int quantity)
        {
            var items = new OrderItem(name,price,quantity);
            order.AddItems(items);
        }

        public decimal GetTotal(Order order)
        {
            return order.GetTotalAmount();
        }
    }
}