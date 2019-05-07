using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Handlers;
using _4_Shared.Enum;
using _4_Shared.ValudeObjects;
using _5_Test.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5_Test.Handlers
{
    public class ClienteHandlerTests
    {
        Cliente _cliente;
        Produto _mouse,_teclado,_monitor;
        public ClienteHandlerTests(){

                var nome= new Nome("Marcus","Fernando");
                var documento = new Documento("36078714007",EnumDocumentType.CPF);
                var email = new Email("marcus@teste.com");
                _cliente = new Cliente(nome,documento,email,"11475789657");
                _mouse = new Produto("mouse","mouse","_mouse",15,2);
                _teclado = new Produto("_teclado","_teclado","_teclado",15,2);
                _monitor = new Produto("_monitor","_monitor","_monitor",15,2);
        }

        [TestMethod]
        public void ValidaCommandCriarCliente()
        {
            var command = new CriaClienteCommand();
            command.PrimeiroNome = "Marcus";
            command.Sobrenome = "Fernando";
            command.Documento = "36078714007";
            command.Email="marcus@teste.com.br";
            command.Telefone="11475789652";
            Assert.IsTrue(command.Valid());
            //mockando os repositórios
            var handler = new ClienteHandler(new FakeClienteRepository(), new FakeSmsRepository());

            var result =  handler.Handle(command);

            Assert.AreNotEqual(null,result);
            Assert.IsTrue(handler.IsValid);
        }
    }
}