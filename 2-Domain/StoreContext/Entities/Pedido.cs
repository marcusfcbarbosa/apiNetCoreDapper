using System;
using System.Linq;
using System.Collections.Generic;
using _2_Domain.StoreContext.Enums;
using FluentValidator;

namespace _2_Domain.StoreContext.Entities
{
    public class Pedido : Notifiable
    {
        private readonly IList<Entrega> _entregas;
        private readonly IList<ItemPedido> _itens;
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            DataCriacao = DateTime.Now;
            Status = StatusPedido.Criado;
            _itens = new List<ItemPedido>();
            _entregas = new List<Entrega>();
        }
        public Cliente Cliente { get; private set; }
        public String Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public StatusPedido Status { get; private set; }

        
        public IReadOnlyCollection<ItemPedido> Itens => _itens.ToArray();
        public IReadOnlyCollection<Entrega> Entregas => _entregas.ToArray();
        public void AdicionaPedidos(ItemPedido itemPedido)
        {
            _itens.Add(itemPedido);
        }
        public void PossuiItens(){
            if(_itens.Count()==0){
                AddNotification("Pedido","Não existem itens para esse pedido");
            }
        }
        public void AdicionaEntrega(Entrega entrega)
        {
            _entregas.Add(entrega);
        }
        //Fecha o Pedido
        public void GerarNotaFiscal()
        {
            //validaçoes
        }
        public void EnviarPedido()
        {
            //validaçoes
            for (int i = 0; i < _itens.Count(); i++)
            {
                var entrega = new Entrega(DateTime.Now.AddDays(5));
                AdicionaEntrega(entrega);
                entrega.Enviado();
            }
            this.Status = StatusPedido.Enviado;
            DataAlteracao = DateTime.Now;
        }
        public void CancelarPedido()
        {
            if (this.Status != StatusPedido.Enviado)
            {
                this.Status = StatusPedido.Cancelado;
                DataAlteracao = DateTime.Now;
            }
        }

        public void CriarPedido()
        {
            this.Status = StatusPedido.Criado;
            DataAlteracao = DateTime.Now;
        }
        public void PedidoPago()
        {
            //validaçoes
            this.Status = StatusPedido.Pago;
            DataAlteracao = DateTime.Now;
        }
    }
}