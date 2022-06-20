using Flunt.Validations;
using paymentContext.Domain.Enuns;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighbordhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighbordhood = neighbordhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            AddNotifications(new Contract<Address>()
                .Requires()
                .IsMinValue(1, "Name.Street", "A moradia deve conter pelo menos um numero")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighbordhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

    }
}