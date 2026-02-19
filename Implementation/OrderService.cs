using domain.entities;
using domain.orderentity;
using IOrderRepositoryInterface;
using OrderServiceInterface;

namespace OrderServiceImplementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _iorderrepo;
        public OrderService(IOrderRepository IOrderRepository)
        {
            _iorderrepo = IOrderRepository;
        }
        public Order CreateOrder(int orderId)
        {
            var order = new Order(orderId);
            _iorderrepo.Add(order);
            return order;
        }

        public void AddItems(Order order,string name,decimal price,int quantity)
        {
            order.AddItems(new OrderItem(name,price,quantity));
        }

        public decimal GetTotal(Order order)
        {
            return order.GetTotalAmount();
        }
    }
}