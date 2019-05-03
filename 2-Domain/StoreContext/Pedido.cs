using System;
using System.Collections.Generic;

namespace _2_Domain.StoreContext
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public String Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public String Status { get; private set; }
        public IList<ItemPedido> Itens {get;set;}
        public IList<Entrega> Entregas {get;set;}

        //Fecha o Pedido
        public void Fechar(){

        }
        public void GerarNotaFiscal(){
            
        }
    }
}