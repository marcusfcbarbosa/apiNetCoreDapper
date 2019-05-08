using System;
using System.Collections.Generic;
using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Queries;

namespace _2_Domain.StoreContext.Repositories.Interfaces
{
    public interface IClienteRepository
    {
         bool CheckaDocumento(string documento);
         bool checkaEmail(string email);
         void Save(Cliente cliente);

         ContadorPedidosCliente RetornaPedidosCliente(string documento);

         IEnumerable<ListaClientesQueryResults> Get();

         ClientesQueryResults GetById(Guid  id);
         
    }
}