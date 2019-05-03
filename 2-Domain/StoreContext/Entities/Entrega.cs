using System;
using _2_Domain.StoreContext.Enums;

namespace _2_Domain.StoreContext.Entities
{
    public class Entrega
    {
        public Entrega(DateTime dataEstimadaEntrega){
            DataCriacao= DateTime.Now;
             DataEstimadaEntrega =dataEstimadaEntrega;
            Status=EntregaStatus.aguardandoEnvio;
        }
        public DateTime DataCriacao { get;private set; } 
        public DateTime DataEstimadaEntrega { get; private set; } 
        public EntregaStatus  Status { get; private set; }
    }
}