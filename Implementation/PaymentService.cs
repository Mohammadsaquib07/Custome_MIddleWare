public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentrepo;
    public PaymentService(IPaymentRepository paymentrepo)
    {
        _paymentrepo = paymentrepo;
    }

    public async Task CreatePaymentAsync(Payment payment)
    {
        if(payment.Amount <= 0)
        {
            throw new Exception("Invalid amount");
        }
        await _paymentrepo.AddAsync(payment);
    }

}