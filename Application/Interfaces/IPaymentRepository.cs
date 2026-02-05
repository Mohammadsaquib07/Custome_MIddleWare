public interface IPaymentRepository
{
    Task AddAsync(Payment payment);
    Task<List<Payment>> GetAllAsync();
}