using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor

        // [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var document = new Document("321", EDocumentType.CNPJ);
            Assert.IsTrue(document.Invalid);
        }

        // [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var document = new Document("89491943000178", EDocumentType.CNPJ);
            Assert.IsTrue(document.Valid);
        }

        //[TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var document = new Document("1234567891", EDocumentType.CPF);
            Assert.IsTrue(document.Invalid);
        }

        //[TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var document = new Document("86168442014", EDocumentType.CPF);
            Assert.IsTrue(document.Valid);
        }
    }
}
