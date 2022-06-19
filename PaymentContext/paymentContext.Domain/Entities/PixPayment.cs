using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PixPayment : Payment
    {
        public PixPayment(string pixKey, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            PixKey = pixKey;
        }

        public string PixKey { get; private set; }
    }

}