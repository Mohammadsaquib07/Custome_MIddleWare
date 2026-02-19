namespace  domain.entities
{
    public class OrderItem
    {
        public string ProductName {get;}
        public decimal Price {get;}
        public int Quantity {get;}

        public OrderItem(string productName,decimal price,int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetTotal()
        {
            return Price * Quantity;
        }
    }
}