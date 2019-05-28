using System;
using System.Collections.Generic;
using _4_Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace _2_Domain.StoreContext.Commands.PedidosCommands.Inputs
{
    public class CriarPedidoCommand  : Notifiable,  ICommand
    {
        public CriarPedidoCommand(){
            ItensPedido = new List<PedidoItemCommand>();
        }
        public Guid ClienteId { get; set; }
        public IList<PedidoItemCommand> ItensPedido { get; set; }
        public bool Valid()
        {
            AddNotifications(new ValidationContract()
                    .Requires()
                    .HasLen(ClienteId.ToString(),36, "ClienteId","Identificador de cliente inválido")
                    .IsGreaterThan(ItensPedido.Count,0,"ItensPedido","Nenhum item do pedido foi encontrado"));
           return this.IsValid;
        }

    }
    public class PedidoItemCommand {
        public Guid ProdutoId { get; set; }
        public decimal Qtd { get; set; }
    }
}
