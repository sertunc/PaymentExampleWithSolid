namespace Payment.Contracts.Interfaces
{
    public interface IBankFactory
    {
        IBank GetBank(string cardNumber);
    }
}
