public class CardPayment:Payment{
    public int CardNumber { get; set; }
    public string? CardHolderName { get; set; }

    public override bool ProcessPayment()
    {
        Console.WriteLine("processing card payment");
        Status = "Success";
        return true;
    }
}