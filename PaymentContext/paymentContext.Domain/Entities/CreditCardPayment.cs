namespace PaymentContext.Domain.Entities
{

    public class CreditCardPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }

}