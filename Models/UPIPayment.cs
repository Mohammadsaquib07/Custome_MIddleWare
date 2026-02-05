public class UPIPayment:Payment
{
    public string? UpiId { get; set; }
    public override bool ProcessPayment()
    {
       Console.WriteLine("Processing Upi payemtn");
       Status = "Success";
       return true;
    }
}