using Flunt.Validations;
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
            AddNotifications(new Contract<Document>()
            .Requires()
            .IsTrue(Validate(), "Document.Number", "Documento inválido")
            );
        }

        public string Number { get; private set; }
        public EDocumentType EDocumentType { get; private set; }
        private bool Validate()
        {
            if (EDocumentType == EDocumentType.CNPJ2 && Number.Length == 14)
            {
                return true;
            }
            if (EDocumentType == EDocumentType.CPF && Number.Length == 11)
            {
                return true;
            }
            return false;

        }
    }
}