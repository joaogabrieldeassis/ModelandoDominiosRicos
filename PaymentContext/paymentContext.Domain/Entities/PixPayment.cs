namespace PaymentContext.Domain.Entities
{
    public class PixPayment : Payment
    {
        public PixPayment(string pixKey, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email)
        : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            PixKey = pixKey;
        }

        public string PixKey { get; private set; }
    }

}