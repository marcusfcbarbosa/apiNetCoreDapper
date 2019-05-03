using System;
using System.Linq;
using System.Collections.Generic;
using _2_Domain.StoreContext.Enums;

namespace _2_Domain.StoreContext.Entities
{
    public class Pedido
    {
        private readonly IList<Entrega> _entregas;
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

        private readonly IList<ItemPedido> _itens;
        public IReadOnlyCollection<ItemPedido> Itens =>_itens.ToArray();
        
        public IReadOnlyCollection<Entrega> Entregas =>_entregas.ToArray();

        public void AdicionaPedidos(Pedido pedido){

        }
        public void AdicionaEntrega(Entrega entrega){
                _entregas.Add(entrega);
        }
        //Fecha o Pedido
        public void Fechar(){
        }
        public void GerarNotaFiscal(){
            
        }
    }
}