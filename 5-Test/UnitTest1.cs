using _2_Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cliente = new Cliente("Marcus",
            "Fernando",
            "254556547","marcus@teste.com.br",
            "11999854787",
            "rua das alamedas,205");

            var pedido = new Pedido(cliente);
            

        }
    }
}
