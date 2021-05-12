using Payment.Contracts.Interfaces;
using System;

namespace Payment.Business
{
    public class PaymentBusiness : IPaymentBusiness
    {
        private readonly IBankFactory bankFactory;

        public PaymentBusiness(IBankFactory bankFactory)
        {
            this.bankFactory = bankFactory ?? throw new ArgumentNullException(nameof(bankFactory));
        }

        public string PayWithCreditCard(string cardNumber, string name, string expireDate, int cvc)
        {
            // some business rules etc.
            var bank = bankFactory.GetBank(cardNumber);

            return bank.PayWithCreditCard(cardNumber, name, expireDate, cvc);
        }
    }
}
