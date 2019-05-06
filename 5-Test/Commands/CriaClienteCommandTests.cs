using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using _2_Domain.StoreContext.Entities;
using _4_Shared.Enum;
using _4_Shared.ValudeObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5_Test.Commands
{
    public class CriaClienteCommandTests
    {
        Cliente _cliente;
        Produto _mouse,_teclado,_monitor;
        public CriaClienteCommandTests(){

                var nome= new Nome("Marcus","Fernando");
                var documento = new Documento("36078714007",EnumDocumentType.CPF);
                var email = new Email("marcus@teste.com");
                _cliente = new Cliente(nome,documento,email,"11475789657");
                _mouse = new Produto("mouse","mouse","_mouse",15,2);
                _teclado = new Produto("_teclado","_teclado","_teclado",15,2);
                _monitor = new Produto("_monitor","_monitor","_monitor",15,2);
        }


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

        //validações externas , que nçao necessitam estar dentro de um controller
        public void CriaCliente(){

            //Verifica se CPF ja existe
            //verifica se email ja existe
            //cria as vo´s
            //cria as entidades
            //validar as entidades e vo´s
            //inserir cliente no banco
            //envia convite no slack
            //envia email de boas vindas
        }
    }
}