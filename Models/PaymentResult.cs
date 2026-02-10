public class PaymentResult
{
    public string? Status { get; }
    public string? TransactionId { get; }
    public string? Message { get; }

    public PaymentResult(string Status,string TransactionId,string msg)
    {
        Status = Status;
        TransactionId = TransactionId;
        Message = msg;
    }
}