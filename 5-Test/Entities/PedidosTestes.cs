using _2_Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flunt.Notifications;
using Flunt.Specifications;
using FluentValidator;
using _4_Shared.ValudeObjects;
using _4_Shared.Enum;

namespace _5_Test.Entities
{
    public class PedidosTestes
    {
        [TestMethod]
        public void CriandoUmPedidoValido()
        {
            var nome = new Nome("Marcus","Fernando");
            var documento = new Documento("25465784578",EnumDocumentType.CPF);
            var email = new Email("marcus@teste.com.br");
            var cliente = new Cliente(nome,
                            documento,
                            email,
                            "11999854787");
            var pedido = new Pedido(cliente);
            var mouse = new Produto("mouse","mouse","mouse",12,1);
            var teclado = new Produto("teclado","teclado","teclado",12,1);
            var impressora = new Produto("impressora","impressora","impressora",12,1);
            
            pedido.AdicionaPedidos(new ItemPedido(mouse,1));
            pedido.AdicionaPedidos(new ItemPedido(teclado,1));
            pedido.AdicionaPedidos(new ItemPedido(impressora,1));
            pedido.PossuiItens();
            Assert.IsTrue(pedido.IsValid);
            //pedido.CriarPedido();
        }

        [TestMethod]
        public void CriandoUmPedidoInValidoPoisNaoTemItens()
        {
            var nome = new Nome("Marcus","Fernando");
            var documento = new Documento("25465784578",EnumDocumentType.CPF);
            var email = new Email("marcus@teste.com.br");
            var cliente = new Cliente(nome,
                            documento,
                            email,
                            "11999854787");
            var pedido = new Pedido(cliente);
            var mouse = new Produto("mouse","mouse","mouse",12,1);
            var teclado = new Produto("teclado","teclado","teclado",12,1);
            var impressora = new Produto("impressora","impressora","impressora",12,1);
            
            pedido.PossuiItens();
            Assert.IsFalse(pedido.IsValid);
        }
    }
}