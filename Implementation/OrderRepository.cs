using domain.orderentity;
using IOrderRepositoryInterface;

namespace OrderRepositoryImplementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public Order GetById(int id)
        {
            return _orders.FirstOrDefault(i => i.Id == id);
        }
    }
}