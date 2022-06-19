using paymentContext.Domain.Enuns;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document
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