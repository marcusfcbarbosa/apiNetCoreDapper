using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Queries;
using _2_Domain.StoreContext.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace _5_Test.Fakes
{
    public class FakeClienteRepository : IClienteRepository
    {
        public bool CheckaDocumento(string documento)
        {
            throw new NotImplementedException();
        }

        public bool checkaEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListaClientesQueryResults> Get()
        {
            throw new NotImplementedException();
        }

        public ClientesQueryResults GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ContadorPedidosCliente RetornaPedidosCliente(string documento)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}