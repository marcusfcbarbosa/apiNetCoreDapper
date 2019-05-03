using System;

namespace _2_Domain.StoreContext.Entities
{
    public class ItemPedido
    {
        public Produto Produto { get; private set; }
        public string Qtd { get; private set; }
        public string Preco { get; private  set; }
    }
}