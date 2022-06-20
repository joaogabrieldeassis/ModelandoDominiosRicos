using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                 .Requires()
                 .IsMinValue(3, "Name.FirstName", "Primeiro nome deve conter pelo menos 3 caracteres")
                 .IsMaxValue(100, "Name.FirstName", "Nome não pode conter mais do que 100 caracteres")
                 .IsMinValue(3, "Name.lastName", "Sobrenome deve conter pelo menos 3 caracteres")
                 .IsMaxValue(3, "Name.lastName", "Nome deve conter pelo menos 3 caracteres")

             );
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}