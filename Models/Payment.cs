public abstract class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? Status { get; set; }
    public abstract bool ProcessPayment();
}