public class CreditCardPayment:IPayment
{
    public PaymentResult ProcessPayment(decimal amount)
    {
        return new PaymentResult(
            "SUCCESS",
            $"cc_{Guid.NewGuid()}",
            "Credit Card payment processed"
        );
    }
}