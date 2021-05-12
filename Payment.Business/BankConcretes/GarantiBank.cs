using Payment.Contracts.Interfaces;

namespace Payment.Business.BankConcretes
{
    public class GarantiBank : IBank
    {
        public string CardNumberPrefix => "456";

        public string PayWithCreditCard(string cardNumber, string name, string expireDate, int cvc)
        {
            // send bank's api etc.
            return $"Payment has been made with {nameof(GarantiBank)} bank";
        }
    }
}
