using _2_Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flunt.Notifications;
using Flunt.Specifications;
using FluentValidator;
using _4_Shared.ValudeObjects;
using _4_Shared.Enum;

namespace _5_Test.ValueObjects
{
    [TestClass]
    public class DocumentsTests
    {
        [TestMethod]
        public void ValidaCpfVerdadeiro()
        {
            var documento = new Documento("35848857873",EnumDocumentType.CPF);
            Assert.IsTrue(documento.IsValid);            
        }
        
        [TestMethod]
        public void ValidaCpfFalso()
        {
            var documento = new Documento("12343423434",EnumDocumentType.CPF);
            Assert.IsFalse(documento.IsValid);            
        }
    }
}