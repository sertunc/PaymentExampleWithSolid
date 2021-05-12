namespace Payment.Contracts.Interfaces
{
    public interface IPaymentBusiness
    {
        string PayWithCreditCard(string cardNumber, string name, string expireDate, int cvc);
    }
}
