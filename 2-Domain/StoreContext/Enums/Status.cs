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

    public enum EnumDocumentType : byte{
        CPF=1,
        CNPJ =2
    }

    public enum TipoEndereco: byte {
        Cobranca =1,
        Entrega=2
    }
}