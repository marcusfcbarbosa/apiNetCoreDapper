using System;

namespace _2_Domain.StoreContext.Enums
{
    public enum StatusPedido : byte
    {
        Criado =1,
        Pago =2,
        Enviado =3,
        Cancelado =4
    }

    public enum EntregaStatus : byte{
        aguardandoEnvio =0,
        enviado=1,
        entregue=2,
        cancelado =3
    }
}