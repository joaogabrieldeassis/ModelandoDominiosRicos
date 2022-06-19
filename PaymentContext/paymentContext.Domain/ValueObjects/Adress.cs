using paymentContext.Domain.Enuns;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighbordhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}