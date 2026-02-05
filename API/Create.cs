using Microsoft.AspNetCore.Mvc;


namespace MiddlewarePractice.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Create : ControllerBase
    {
        private readonly IPaymentService _service;
        public Create(IPaymentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment(CreatePaymentDto paymentdto)
        {
            Payment payment = paymentdto.PaymentType switch
            {
                "Card" => new CardPayment {Amount = paymentdto.Amount,CardNumber = paymentdto.CardNumber,CardHolderName="Mohammad Saquib"},
                "UPI" => new UPIPayment {Amount = paymentdto.Amount,UpiId = paymentdto.UpiId},
                "Wallet" => new WalletPayment {Amount = paymentdto.Amount,WalletProvider = paymentdto.WalletName},
                _=> throw new Exception("Invalid payment type")
            };
            await _service.CreatePaymentAsync(payment);
            return Ok();
        }

    }

}