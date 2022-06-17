namespace PaymentContext.Domain.Entities
{

    public class PayPalPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }

}