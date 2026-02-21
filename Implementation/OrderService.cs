using domain.entities;
using domain.orderentity;
using IOrderRepositoryInterface;
using OrderServiceInterface;
using domain.discountstrategyinterface;

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

        public void AddItems(Order order, string name, decimal price, int quantity)
        {
            var items = new OrderItem(name, price, quantity);
            order.AddItems(items);
        }

        public decimal GetTotal(Order order, IDiscountStrategy discountStrategy)
        {
            return order.GetTotalAmount(discountStrategy);
        }

        public decimal GetDiscountApplied(Order order, IDiscountStrategy discountStrategy)
        {
            var raw = order.GetRawTotalAmount();
            var discounted = order.GetTotalAmount(discountStrategy);
            return raw - discounted;
        }
    }
}