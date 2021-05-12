namespace Payment.Contracts.Interfaces
{
    public interface IBank
    {
        string CardNumberPrefix { get; }

        string PayWithCreditCard(string cardNumber, string name, string expireDate, int cvc);
    }
}
