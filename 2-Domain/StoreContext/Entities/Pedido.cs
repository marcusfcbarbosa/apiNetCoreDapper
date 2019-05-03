using System;
using System.Collections.Generic;
using _2_Domain.StoreContext.Enums;

namespace _2_Domain.StoreContext.Entities
{
    public class Pedido
    {
        public Pedido(Cliente cliente){
                Cliente =cliente;
                Numero = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
                DataCriacao = DateTime.Now;
                Status = StatusPedido.Criado;
                
        }
        public Cliente Cliente { get; private set; }
        public String Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public StatusPedido Status { get; private set; }

        private List<ItemPedido> _itens {get;set;} =  new List<ItemPedido>();
        public IReadOnlyCollection<ItemPedido> Itens {get; private set;}= new List<ItemPedido>();

        private List<Entrega> _entregas {get;set;} =  new List<Entrega>();
        public IReadOnlyCollection<Entrega> Entregas {get; private set;}= new List<Entrega>();

        public void AdicionaPedidos(Pedido pedido){

        }
        //Fecha o Pedido
        public void Fechar(){
        }
        public void GerarNotaFiscal(){
            
        }
    }
}