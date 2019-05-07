using System;
using _4_Shared.Entities;
using FluentValidator;

namespace _2_Domain.StoreContext.Entities
{
    public class ItemPedido : Entity
    {
        public ItemPedido(Produto produto,int qtd){
            Produto = produto;
            Qtd= qtd;
            Preco = produto.Preco;
        }

        public Produto Produto { get; private set; }
        public int Qtd { get; private set; }
        public decimal Preco { get; private  set; }
    }
}