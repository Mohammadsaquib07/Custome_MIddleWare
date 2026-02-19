using domain.entities;
using domain.Enums;
using System.Linq;

namespace domain.orderentity
{
    public class Order
    {
        private readonly List<OrderItem> orderItems = new();
        public int Id {get;}

        public OrderStatus Status {get;private set;}

        public Order(int id)
        {
            Id = id;
            Status = OrderStatus.Created;
        }

        public void AddItems(OrderItem items)
        {
            orderItems.Add(items);
        }

        public decimal GetTotalAmount()
        {
            return orderItems.Sum(i=>i.GetTotal());
        }

        public void MarkAsPaid()
        {
            Status = OrderStatus.Paid;
        }
    }
}