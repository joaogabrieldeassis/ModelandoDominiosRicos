using paymentContext.Domain.Enuns;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType eDocumentType)
        {
            EDocumentType = eDocumentType;
            Number = number;
        }

        public string Number { get; private set; }
        public EDocumentType EDocumentType { get; private set; }
    }
}