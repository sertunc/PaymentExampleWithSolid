using Microsoft.AspNetCore.Mvc;
using Payment.Contracts.Interfaces;
using System;

namespace Payment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentBusiness paymentBusiness;

        public PaymentController(IPaymentBusiness paymentBusiness)
        {
            this.paymentBusiness = paymentBusiness ?? throw new ArgumentNullException(nameof(paymentBusiness));
        }

        [HttpPost]
        public IActionResult Post(string cardNumber, string name, string expireDate, int cvc)
        {
            var result = paymentBusiness.PayWithCreditCard(cardNumber, name, expireDate, cvc);

            return Ok(result);
        }
    }
}
