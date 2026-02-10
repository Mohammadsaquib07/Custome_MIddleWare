public interface IPayment
{
    PaymentResult ProcessPayment(decimal Amount);
}