using System;

namespace _2_Domain.StoreContext.Queries
{
    public class ContadorPedidosCliente
    {
        public Guid Id { get; set; }
        public string  Nome { get; set; }
        public string Documento { get; set; }
        public int Pedidos { get; set; }
    }
}