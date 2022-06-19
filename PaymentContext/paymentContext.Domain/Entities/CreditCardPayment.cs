using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{

    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, string address, Email email)
        : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }

}