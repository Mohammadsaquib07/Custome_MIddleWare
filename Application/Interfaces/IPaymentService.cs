public interface IPaymentService
{
    Task CreatePaymentAsync(Payment payment);
}