using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5_Test.Commands
{
    public class CriaClienteCommandTests
    {
        [TestMethod]
        public void ValidaCommandCriacaoClienteValido()
        {
            var command = new CriaClienteCommand();
            command.PrimeiroNome="Marcus";
            command.Sobrenome="Fernando";
            command.Documento="35972509040";
            command.Email="marcus@teste.com";
            command.Telefone="11987454698";
            Assert.IsTrue(command.Valid());
        }
    }
}