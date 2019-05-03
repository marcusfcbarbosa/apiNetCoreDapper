using System;

namespace _2_Domain.StoreContext
{
    public class Entrega
    {
        public DateTime DataCriacao { get;private set;} 
        public DateTime DataEstimadaEntrega { get; private set;} 
        public string  Status { get; private set; }
    }
}