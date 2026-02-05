public class WalletPayment:Payment
{
    public string? WalletProvider { get; set; }
    public override bool ProcessPayment()
    {
        Console.WriteLine("Processing wallet payement");
        Status = "Succes";
        return true;
    }
}