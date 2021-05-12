using Payment.Contracts.Interfaces;

namespace Payment.Business.BankConcretes
{
    public class VakifBank : IBank
    {
        public string CardNumberPrefix => "789";

        public string PayWithCreditCard(string cardNumber, string name, string expireDate, int cvc)
        {
            // send bank's api etc.
            return $"Payment has been made with {nameof(VakifBank)} bank";
        }
    }
}
