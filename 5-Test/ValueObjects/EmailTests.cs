using _2_Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flunt.Notifications;
using Flunt.Specifications;
using FluentValidator;
using _4_Shared.ValudeObjects;
using _4_Shared.Enum;

namespace _5_Test.ValueObjects
{
    public class EmailTests
    {
        
        [TestMethod]
        public void ValidaEmailValido()
        {
            var email = new Email("marcus@teste.com.br");
            Assert.IsTrue(email.IsValid);            
        }
    }
}