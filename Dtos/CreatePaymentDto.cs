public class CreatePaymentDto
{
    public string? PaymentType { get; set; }
    public decimal Amount { get; set; }

    // Card
    public int CardNumber { get; set; }

    // UPI
    public string? UpiId { get; set; }

    // Wallet
    public string? WalletName { get; set; }
}