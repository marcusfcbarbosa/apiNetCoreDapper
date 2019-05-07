using System;
using _4_Shared.Enum;
using FluentValidator;

namespace _2_Domain.StoreContext.Entities
{
    public class Entrega :Notifiable
    {
        public Entrega(DateTime dataEstimadaEntrega){
            DataCriacao= DateTime.Now;
            DataEstimadaEntrega =dataEstimadaEntrega;
            Status=EntregaStatus.aguardandoEnvio;
        }
        public DateTime DataCriacao { get;private set; } 
        public DateTime DataEstimadaEntrega { get; private set; } 
        public EntregaStatus  Status { get; private set; }

        public void Enviado(){
            Status=EntregaStatus.enviado;
        }
    }
}