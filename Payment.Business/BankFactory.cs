using Payment.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Payment.Business
{
    public class BankFactory : IBankFactory
    {
        private readonly IEnumerable<IBank> bankList;

        public BankFactory(IEnumerable<IBank> bankList)
        {
            this.bankList = bankList ?? throw new ArgumentNullException(nameof(bankList));
        }

        public IBank GetBank(string cardNumber)
        {
            var bank = bankList.FirstOrDefault(x => x.CardNumberPrefix.StartsWith(cardNumber));
            return bank ?? throw new ArgumentNullException(nameof(bankList));
        }
    }
}
