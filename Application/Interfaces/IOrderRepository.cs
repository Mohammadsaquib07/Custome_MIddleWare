using domain.orderentity;

namespace IOrderRepositoryInterface
{
    public interface IOrderRepository
    {
        void Add(Order order);
        Order GetById(int id);
    }
}